using Domain.Enums;
using Domain.Primitives;

namespace Domain.Entities;

public class Invitation : Entity
{
    public int MemberID { get; private set; }
    public int GatheringID { get; private set; }
    public InvitationStatus InvitationStatus { get; private set; }    
    private Invitation() { }
    private Invitation(int memberId, int gatheringId)
    {
        MemberID = memberId;
        GatheringID = gatheringId;
        InvitationStatus = InvitationStatus.Pending;
    }
    internal static Invitation Create(int memberId, int gatheringId)
    {
        return new Invitation
        {
            MemberID = memberId,
            GatheringID = gatheringId
        };
    }
    public void Confirm()
    {
        InvitationStatus = InvitationStatus.Accepted;
    }
    public void Decline()
    {
        InvitationStatus = InvitationStatus.Declined;
    }

}

