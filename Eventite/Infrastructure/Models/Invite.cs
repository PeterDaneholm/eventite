namespace ConsoleAppTest.Infrastructure.Models;

public class Invite
{

    public enum StatusOptions
    {
        Accepted,
        Declined,
        Pending
    }
    public Guid id { set; get; }
    public Guid eventId { get; set; }
    public Guid userId { get; set; }
    public StatusOptions status { get; set; }
}
