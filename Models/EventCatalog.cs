namespace BlazorCourseAssignment.Models;

public static class EventCatalog
{
    private static readonly IReadOnlyList<PublicEvent> Events =
    [
        new(
            "indie-live-night",
            "Indie Live Night",
            new DateTime(2026, 10, 29),
            "The Lantern Room",
            18m,
            "Discover rising indie artists in an intimate live-music venue, with a full evening of original songs and guest performances.",
            [
                new("Maya Rivers", "Singer-songwriter"),
                new("The Paper Moons", "Indie pop band")
            ],
            ["North Sound Collective", "Local Music Fund"],
            "images/event-banner.svg"),
        new(
            "future-of-ai",
            "The Future of AI",
            new DateTime(2026, 11, 5),
            "Riverside Convention Centre",
            32m,
            "A one-day technology conference exploring practical AI, responsible design, and the tools shaping the next generation of digital products.",
            [
                new("Dr. Amina Okafor", "AI researcher"),
                new("Leo Park", "Technology journalist")
            ],
            ["BrightByte", "Open Knowledge Foundation"],
            "images/event-banner.svg"),
        new(
            "ideas-worth-sharing",
            "Ideas Worth Sharing",
            new DateTime(2026, 11, 12),
            "The Grand Theatre",
            12m,
            "An evening of short, inspiring talks from local thinkers sharing fresh perspectives on science, creativity, and everyday life.",
            [
                new("Nora Bennett", "Climate storyteller"),
                new("Professor Elias Chen", "Neuroscientist")
            ],
            ["City Arts Council"],
            "images/event-banner.svg"),
        new(
            "autumn-lights-festival",
            "Autumn Lights Festival",
            new DateTime(2026, 11, 21),
            "Old Town Square",
            0m,
            "Celebrate the season with live folk music, lantern installations, local food stalls, and activities for all ages.",
            [
                new("The Rowan Trio", "Folk band"),
                new("Lina Haddad", "Light artist")
            ],
            ["Old Town Cultural Association", "Harvest Market"],
            "images/event-banner.svg"),
        new(
            "classic-film-evening",
            "Classic Film Evening: City Lights",
            new DateTime(2026, 11, 28),
            "Rialto Picture House",
            9m,
            "Enjoy a restored classic on the big screen, followed by a relaxed discussion about its history and influence.",
            [
                new("Amir Patel", "Film historian"),
                new("Sofia Laurent", "Cinema host")
            ],
            ["Rialto Picture House"],
            "images/event-banner.svg"),
        new(
            "winter-jazz-session",
            "Winter Jazz Session",
            new DateTime(2026, 12, 4),
            "Blue Note Cellar",
            24m,
            "Spend an evening with a live jazz quartet performing original arrangements and beloved standards in a cozy club setting.",
            [
                new("Elena Cruz", "Jazz vocalist"),
                new("Marcus Bell Quartet", "Live jazz")
            ],
            ["Blue Note Cellar", "City Jazz Society"],
            "images/event-banner.svg"),
        new(
            "makers-and-makers-market",
            "Makers & Makers Market",
            new DateTime(2026, 12, 12),
            "Foundry Hall",
            4m,
            "Browse handmade ceramics, prints, textiles, and gifts from independent makers, with demonstrations throughout the day.",
            [
                new("Iris Morgan", "Ceramic artist"),
                new("Theo James", "Printmaker")
            ],
            ["Foundry Hall", "Independent Makers Guild"],
            "images/event-banner.svg"),
        new(
            "winter-solstice-concert",
            "Winter Solstice Concert",
            new DateTime(2026, 12, 19),
            "St. Anne's Hall",
            20m,
            "A seasonal concert bringing together a chamber orchestra and community choir for an uplifting evening of music.",
            [
                new("Amara Wells", "Orchestra conductor"),
                new("Northside Community Choir", "Choir")
            ],
            ["St. Anne's Music Trust"],
            "images/event-banner.svg"),
        new(
            "new-year-comedy-show",
            "New Year Comedy Show",
            new DateTime(2027, 1, 9),
            "The Laughing Fox",
            16m,
            "Start the year with a night of stand-up comedy featuring sharp new voices and a special guest headliner.",
            [
                new("Jamie Cole", "Stand-up comedian"),
                new("Rae Thompson", "Comedian and host")
            ],
            ["The Laughing Fox"],
            "images/event-banner.svg"),
        new(
            "open-source-weekend",
            "Open Source Weekend",
            new DateTime(2027, 1, 23),
            "TechWorks Campus",
            10m,
            "Collaborate on open-source projects, join beginner-friendly coding sessions, and meet developers from the local tech community.",
            [
                new("Priya Nair", "Open-source maintainer"),
                new("Owen Brooks", "Developer educator")
            ],
            ["Code Commons", "TechWorks"],
            "images/event-banner.svg"),
        new(
            "lunar-new-year-celebration",
            "Lunar New Year Celebration",
            new DateTime(2027, 2, 6),
            "Civic Cultural Centre",
            0m,
            "Welcome the new year with traditional music and dance, cultural demonstrations, community food, and family activities.",
            [
                new("Mei Lin Dance Ensemble", "Traditional dance"),
                new("Kai Wong", "Lion dance performer")
            ],
            ["Civic Cultural Centre", "Community Culture Network"],
            "images/event-banner.svg"),
        new(
            "independent-theatre-night",
            "Independent Theatre Night",
            new DateTime(2027, 2, 20),
            "The Lantern Theatre",
            14m,
            "See an original one-act play by local writers, followed by a conversation with the performers and creative team.",
            [
                new("Milo Grant", "Playwright"),
                new("The Lantern Players", "Theatre company")
            ],
            ["Lantern Theatre Fund"],
            "images/event-banner.svg"),
        new(
            "spring-food-fair",
            "Spring Street Food Fair",
            new DateTime(2027, 3, 13),
            "Riverside Promenade",
            0m,
            "Sample food from local kitchens and pop-ups, enjoy acoustic sets, and meet the people behind the neighborhood's food scene.",
            [
                new("Chef Lucia Romano", "Guest chef"),
                new("DJ Sol", "Live music")
            ],
            ["Riverside Market Association"],
            "images/event-banner.svg"),
        new(
            "design-and-tech-expo",
            "Design & Technology Expo",
            new DateTime(2027, 4, 10),
            "Innovation Museum",
            22m,
            "Explore interactive exhibits and talks at the intersection of digital technology, product design, and everyday creativity.",
            [
                new("Riley Kim", "Interaction designer"),
                new("Dr. Mateo Silva", "Creative technologist")
            ],
            ["Innovation Museum", "BrightByte"],
            "images/event-banner.svg"),
        new(
            "city-ballet-spring",
            "City Ballet: Spring",
            new DateTime(2027, 5, 8),
            "The Grand Theatre",
            30m,
            "Experience a contemporary ballet performance with original choreography, live accompaniment, and a post-show artist talk.",
            [
                new("City Ballet Company", "Dance company"),
                new("Anika Petrov", "Choreographer")
            ],
            ["The Grand Theatre", "City Arts Council"],
            "images/event-banner.svg"),
        new(
            "summer-sounds",
            "Summer Sounds Live",
            new DateTime(2027, 6, 19),
            "Meadow Park",
            35m,
            "A full day of live music across two outdoor stages, with local bands, food trucks, and space to picnic with friends.",
            [
                new("The Paper Moons", "Indie pop band"),
                new("Maya Rivers", "Singer-songwriter")
            ],
            ["North Sound Collective", "Meadow Park"],
            "images/event-banner.svg"),
        new(
            "photography-walk",
            "Street Photography Walk",
            new DateTime(2027, 7, 10),
            "Meet at Central Gallery",
            5m,
            "Join a guided city walk to practice composition and storytelling, then share your favorite images in a group critique.",
            [
                new("Sofia Laurent", "Documentary photographer"),
                new("Theo James", "Visual artist")
            ],
            ["Central Gallery"],
            "images/event-banner.svg"),
        new(
            "science-after-dark",
            "Science After Dark",
            new DateTime(2027, 8, 14),
            "City Science Museum",
            18m,
            "An after-hours museum experience with hands-on demonstrations, short talks, and curious conversations with researchers.",
            [
                new("Professor Elias Chen", "Neuroscientist"),
                new("Dr. Amina Okafor", "AI researcher")
            ],
            ["City Science Museum"],
            "images/event-banner.svg"),
        new(
            "harvest-cultural-weekend",
            "Harvest Cultural Weekend",
            new DateTime(2027, 9, 11),
            "Old Town Square",
            0m,
            "Celebrate the city's many traditions with music, dance, crafts, and food shared by local cultural groups.",
            [
                new("Mei Lin Dance Ensemble", "Traditional dance"),
                new("Amara Wells", "Community choir director")
            ],
            ["Old Town Cultural Association"],
            "images/event-banner.svg")
    ];

    private static readonly (string Name, string Description, string Location)[] CalendarEventIdeas =
    [
        ("Live Music Showcase", "Catch emerging local performers and established artists in an intimate live-music setting.", "The Lantern Room"),
        ("Technology & AI Forum", "Explore new ideas in technology with demonstrations, practical talks, and time for questions.", "TechWorks Campus"),
        ("Ideas Worth Sharing", "Hear short, engaging talks from people with fresh perspectives on science, culture, and creativity.", "The Grand Theatre"),
        ("Independent Film Night", "Watch a carefully selected film and stay for a friendly discussion with local cinema guests.", "Rialto Picture House"),
        ("Artisan Market", "Meet independent makers and browse handmade art, ceramics, textiles, and locally designed goods.", "Foundry Hall"),
        ("Global Food Festival", "Taste dishes from local kitchens and celebrate the many food traditions in our community.", "Riverside Promenade"),
        ("Jazz Club Session", "Enjoy live jazz from local musicians in a relaxed club setting.", "Blue Note Cellar"),
        ("Contemporary Dance Performance", "Experience original choreography by performers from the local dance scene.", "The Lantern Theatre"),
        ("Science After Dark", "Join researchers for surprising demonstrations and short talks in a museum after hours.", "City Science Museum"),
        ("Comedy on the Square", "Spend the evening with stand-up performers and a lively outdoor audience.", "Old Town Square"),
        ("Creative Coding Workshop", "Build a small creative technology project with guidance from friendly local developers.", "Innovation Museum"),
        ("Cultural Celebration", "Enjoy traditional music, dance, crafts, and food shared by community groups.", "Civic Cultural Centre")
    ];

    private static readonly IReadOnlyList<PublicEvent> CalendarEvents = CreateCalendarEvents();
    private static readonly IReadOnlyList<PublicEvent> AllEvents =
        Events.Concat(CalendarEvents).OrderBy(eventItem => eventItem.Date).ToArray();
    private static readonly IReadOnlyDictionary<DateOnly, IReadOnlyList<PublicEvent>> EventsByDate =
        AllEvents
            .GroupBy(eventItem => DateOnly.FromDateTime(eventItem.Date))
            .ToDictionary(
                group => group.Key,
                group => (IReadOnlyList<PublicEvent>)group.ToArray());
    private static readonly IReadOnlyDictionary<string, PublicEvent> EventsById =
        AllEvents.ToDictionary(eventItem => eventItem.Id, StringComparer.Ordinal);

    public static IReadOnlyList<PublicEvent> All => AllEvents;

    public static IReadOnlyList<PublicEvent> OnDate(DateTime date) =>
        EventsByDate.TryGetValue(DateOnly.FromDateTime(date), out var events)
            ? events
            : Array.Empty<PublicEvent>();

    public static PublicEvent? FindById(string id) =>
        EventsById.TryGetValue(id, out var eventItem) ? eventItem : null;

    private static IReadOnlyList<PublicEvent> CreateCalendarEvents()
    {
        var calendarEvents = new List<PublicEvent>();
        var today = DateTime.Today;
        var firstMonth = new DateTime(today.Year, today.Month, 1);
        var guestProfiles = new FeaturedGuest[][]
        {
            [new("Maya Rivers", "Singer-songwriter"), new("The Paper Moons", "Indie pop band")],
            [new("Dr. Amina Okafor", "AI researcher"), new("Leo Park", "Technology journalist")],
            [new("Nora Bennett", "Climate storyteller"), new("Professor Elias Chen", "Neuroscientist")],
            [new("Sofia Laurent", "Cinema host"), new("Amir Patel", "Film historian")]
        };
        var eventPartners = new[]
        {
            new[] { "North Sound Collective", "Local Music Fund" },
            new[] { "BrightByte", "Code Commons" },
            new[] { "City Arts Council", "Central Gallery" },
            new[] { "Riverside Market Association", "Civic Cultural Centre" }
        };

        for (var monthOffset = 0; monthOffset < 36; monthOffset++)
        {
            var month = firstMonth.AddMonths(monthOffset);
            var daysWithoutEvents = (month.Year, month.Month) switch
            {
                (2026, 10) => new HashSet<int> { 1, 2, 3, 4, 5 },
                (2026, 11) => new HashSet<int> { 1, 8, 15, 22, 29 },
                (2026, 12) => new HashSet<int> { 6, 13, 20, 27, 31 },
                _ => new HashSet<int>()
            };

            for (var day = 1; day <= DateTime.DaysInMonth(month.Year, month.Month); day++)
            {
                var date = month.AddDays(day - 1);
                var isDenseInitialMonth = month.Year == 2026 && month.Month is >= 10 and <= 12;
                var isGeneratedEventDay = date.DayOfWeek is DayOfWeek.Monday or DayOfWeek.Wednesday or DayOfWeek.Friday;

                if (date < today ||
                    daysWithoutEvents.Contains(day) ||
                    Events.Any(eventItem => eventItem.Date.Date == date.Date) ||
                    (!isDenseInitialMonth && !isGeneratedEventDay))
                {
                    continue;
                }

                var ideaIndex = (day + month.Month + month.Year) % CalendarEventIdeas.Length;
                var guestIndex = ideaIndex % guestProfiles.Length;
                var idea = CalendarEventIdeas[ideaIndex];

                calendarEvents.Add(new PublicEvent(
                    $"calendar-{date:yyyyMMdd}",
                    $"{idea.Name} - {date:MMM d}",
                    date,
                    idea.Location,
                    ideaIndex % 3 == 0 ? 0m : 8m,
                    idea.Description,
                    guestProfiles[guestIndex],
                    eventPartners[guestIndex],
                    "images/event-banner.svg"));
            }
        }

        return calendarEvents;
    }
}
