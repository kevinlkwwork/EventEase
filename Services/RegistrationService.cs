using EventEase.Models;
using System.Collections.Generic;

namespace EventEase.Services
{
    public class RegistrationService
    {
        private List<Registration> registrations = new List<Registration>();

        public void AddRegistration(Registration registration)
        {
            registrations.Add(registration);
        }

        public List<Registration> GetRegistrations()
        {
            return registrations;
        }

        public List<Registration> GetRegistrationsByEventId(int eventId)
        {
            return registrations.FindAll(r => r.EventId == eventId);
        }
    }
}
