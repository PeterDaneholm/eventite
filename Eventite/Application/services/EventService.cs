using ConsoleAppTest.Infrastructure.Models;
using ConsoleAppTest.repositories;
using System.Diagnostics.Contracts;

public class EventService
{
    private EventRepository _eventRepository;
    private UserRepository _userRepository;
    private InviteRepository _inviteRepository;

    public EventService()
    {
        _eventRepository = new EventRepository();
        _userRepository = new UserRepository();
        _inviteRepository = new InviteRepository();
    }
    public string RegisterEvent(Event newEvent, User host)
    {
        string result = "";
        try
        {
            _eventRepository.Add(newEvent);
            result = "Event succesfully added";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            result = $"Could not add event - ${e}";
            throw;
        }

        return result;
    }

    public void AssignHost(Event newEvent, User eventHost)
    {
        if (newEvent.host == "")
        {
            newEvent.host = eventHost.name;
            Console.WriteLine($"Host for {newEvent.title} is: {eventHost.name}");
            return;
        }
        else
        {
            return;
        }
    }

    public void RespondToEvent(Guid eventId, Guid inviteId, string user, string response)
    {
        Event foundEvent = _eventRepository.GetEvent(eventId);
        User invitedUser = _userRepository.GetSpecificUser(user);

        foundEvent.invites.Remove(inviteId);
        if (response == "Accepted")
        {
            foundEvent.attending.Add(invitedUser);
        }
    }

}