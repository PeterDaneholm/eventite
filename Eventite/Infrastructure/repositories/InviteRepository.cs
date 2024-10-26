namespace ConsoleAppTest.repositories;
using Infrastructure.Models;

public class InviteRepository
{
    private List<Invite> allInvites = new List<Invite>();

    public Invite GetInvite(Guid inviteId)
    {
        Invite foundInvite = allInvites.FirstOrDefault(i => i.id == inviteId);
        return foundInvite;
    }

    public Invite CreateInvite(Guid eventId, Guid userId)
    {
         Invite fetchedInvite = new Invite
         {
             id = new Guid(),
             eventId = eventId,
             userId = userId,
             status = Invite.StatusOptions.Pending,
         };
         
         return fetchedInvite;       
    }

    public List<Invite> GetAllInvites()
    {
        return allInvites;
    }

    public string RemoveInvite(Guid inviteId)
    {
        Invite foundInvite = allInvites.FirstOrDefault(i => i.id == inviteId);
        if (foundInvite != null)
        {
            allInvites.Remove(foundInvite);
            return "Invite removed";
        }
        
        return "Invite not found";
    }
}