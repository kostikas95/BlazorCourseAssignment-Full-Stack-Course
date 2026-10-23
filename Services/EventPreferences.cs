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

    public int AttendingCountFor(string eventId) =>
        preferences.TryGetValue(eventId, out var preference)
        && preference.AttendanceStatus == AttendanceStatus.Attending
            ? 1
            : 0;

    public void SetAttendance(string eventId, AttendanceStatus? status) =>
        For(eventId).AttendanceStatus = status;
}
