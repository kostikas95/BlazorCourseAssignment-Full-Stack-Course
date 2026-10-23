const observers = new WeakMap();

export function observeCalendarSentinel(root, sentinel, dotNetReference) {
    const observer = new IntersectionObserver(async entries => {
        if (!entries.some(entry => entry.isIntersecting)) {
            return;
        }

        observer.unobserve(sentinel);
        try {
            const hasMoreMonths = await dotNetReference.invokeMethodAsync("LoadMoreMonths");
            if (observers.get(sentinel) !== observer) {
                return;
            }

            if (hasMoreMonths) {
                observer.observe(sentinel);
            } else {
                observer.disconnect();
                observers.delete(sentinel);
            }
        } catch (error) {
            console.error("The calendar could not load more months.", error);
            try {
                await dotNetReference.invokeMethodAsync(
                    "OnCalendarLoadError",
                    error instanceof Error ? error.message : String(error));
            } catch (notificationError) {
                console.error("The calendar load error could not be reported to the app.", notificationError);
            }
        }
    }, {
        root,
        rootMargin: "500px 0px",
        threshold: 0
    });

    observers.set(sentinel, observer);
    observer.observe(sentinel);
}

export function disposeCalendarSentinel(sentinel) {
    const observer = observers.get(sentinel);
    if (observer) {
        observer.disconnect();
        observers.delete(sentinel);
    }
}

export function retryCalendarSentinel(sentinel) {
    const observer = observers.get(sentinel);
    if (!observer) {
        throw new Error("The calendar scroll observer is unavailable.");
    }

    observer.observe(sentinel);
}
