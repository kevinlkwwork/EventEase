using EventEase.Models;
using System.Collections.Generic;
using System.Linq;

namespace EventEase.Services
{
    public class EventService
    {
        private List<Event> events = new List<Event>
        {
            new Event { Id = 1, Name = "Event 1", Date = DateTime.Now, Location = "Location 1" },
            new Event { Id = 2, Name = "Event 2", Date = DateTime.Now.AddDays(1), Location = "Location 2" }
        };

        public List<Event> GetEvents()
        {
            return events;
        }

        public Event GetEventById(int id)
        {
            return events.FirstOrDefault(e => e.Id == id);
        }

        public void AddEvent(Event newEvent)
        {
            newEvent.Id = events.Count + 1;
            events.Add(newEvent);
        }
    }
}
