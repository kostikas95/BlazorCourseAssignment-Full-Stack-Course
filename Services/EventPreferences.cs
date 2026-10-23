using BlazorCourseAssignment.Models;

namespace BlazorCourseAssignment.Services;

public sealed class EventPreferences
{
    private readonly Dictionary<string, EventPreference> preferences = new(StringComparer.Ordinal);

    public EventPreference For(string eventId)
    {
        if (!preferences.TryGetValue(eventId, out var preference))
        {
            preference = new EventPreference();
            preferences.Add(eventId, preference);
        }

        return preference;
    }
}
