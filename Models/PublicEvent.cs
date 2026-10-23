namespace BlazorCourseAssignment.Models;

public sealed record PublicEvent(
    string Id,
    string EventName,
    DateTime Date,
    string Location,
    decimal EntryFee,
    string Description,
    IReadOnlyList<FeaturedGuest> FeaturedGuests,
    IReadOnlyList<string> Sponsors,
    string BackgroundImage);

public sealed record FeaturedGuest(string Name, string Role);
