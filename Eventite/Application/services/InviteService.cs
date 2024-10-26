using ConsoleAppTest.repositories;

namespace ConsoleAppTest.Application.services;
using Infrastructure.Models;

public class InviteService
{
    private InviteRepository _inviteRepository;

    public InviteService()
    {
        _inviteRepository = new InviteRepository();
    }
        
        
    public Invite RespondToInvite(string state, Guid inviteId, Guid userId, Guid eventId)
    {
        Invite updatedInvite = _inviteRepository.GetInvite(inviteId);
        if (Enum.TryParse(state, out Invite.StatusOptions parsedStatus))
        {
            updatedInvite.status = parsedStatus;
        }
        else
        {
            return updatedInvite;
        }

        return updatedInvite;
    }

    public string DeleteInvite(Guid inviteId)
    {
        string deleteResponse = _inviteRepository.RemoveInvite(inviteId);
        

        return deleteResponse;
    }
}
