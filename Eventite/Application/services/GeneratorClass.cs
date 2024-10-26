using System;
using System.Reflection.Metadata.Ecma335;


public class GeneratorClass
{
    public User GenerateUser()
    {
        User testUser = new User
        {
            name = "Test User",
            username = "testingUsers",
            previousEvents = []
        };

        return testUser;
    }

    public Event GenerateEvent()
    {
        Event testEvent = new Event
        {
            title = "Spikeball",
            date = "Friday",
            location = "Amager Beach",
            duration = 2,
            description = "We'll go play spikeball and have some nice rallies and good aces"
        };

        return testEvent;
    }
}