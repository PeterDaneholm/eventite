namespace ConsoleAppTest.Infrastructure.Factories;
using Infrastructure.Models;

public class EventFactory
{

    public Event NewEvent(string name, string description)
    {
        Guid id = new Guid();
        Event newEvent = new Event
        {
            title = name,
            description = description,
            eventId = id,
            date = new DateTime().Date,
            invites = [],
            attending = [],
        };

        return newEvent;
    }
}