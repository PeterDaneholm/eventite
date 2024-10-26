namespace ConsoleAppTest.Infrastructure.Models;

public class User
{
    public Guid userId { get; set; }
    public string name { get; set; }
    public List<Event> pastEvents { get; set; }
    public List<Event> futureEvents { get; set; }
    public List<Invite> unansweredInvites { get; set; }
    
}