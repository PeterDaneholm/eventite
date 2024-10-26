using ConsoleAppTest.Infrastructure.Models;
using ConsoleAppTest.repositories;

public class UserService
{
    private UserRepository _userRepository;
    private EventRepository _eventRepository;

    public UserService()
    {
        _userRepository = new UserRepository();
        _eventRepository = new EventRepository();
    }

    public User FindUser(string username)
    {
        User foundUser = _userRepository.GetSpecificUser(username);

        return foundUser;
    }

    public string AddEventToFutureEvents(Guid eventId, string username, Guid inviteId)
    {
        User foundUser = _userRepository.GetSpecificUser(username);
        Event invitedEvent = _eventRepository.GetEvent(eventId);
        foundUser.futureEvents.Append(invitedEvent);
        foundUser.unansweredInvites.Remove(inviteId);

        return "Event added to User's upcoming events";
    }
    
}