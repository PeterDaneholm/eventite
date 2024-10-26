namespace ConsoleAppTest.Infrastructure.Models;

public class Event
{
    public Guid eventId { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public string host { get; set; }
    public DateTime date { get; set; }
    public List<User> attending { get; set; }
    public List<Invite> invites { get; set; }
    
}