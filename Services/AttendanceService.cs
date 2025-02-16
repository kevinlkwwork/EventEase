using System.Collections.Generic;
using System.Linq;
using EventEase.Models;

namespace EventEase.Services
{
    public class AttendanceService
    {
        private readonly List<Attendance> _attendances = new List<Attendance>();

        public void MarkAttendance(int eventId, string email)
        {
            var attendance = _attendances.FirstOrDefault(a => a.EventId == eventId && a.Email == email);
            if (attendance == null)
            {
                _attendances.Add(new Attendance { EventId = eventId, Email = email });
            }
        }

        public bool IsAttending(int eventId, string email)
        {
            return _attendances.Any(a => a.EventId == eventId && a.Email == email);
        }

        public List<Attendance> GetAttendancesByEventId(int eventId)
        {
            return _attendances.Where(a => a.EventId == eventId).ToList();
        }
    }
}
