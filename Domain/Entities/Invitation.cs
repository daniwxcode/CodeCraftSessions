using Domain.Enums;
using Domain.Primitives;

namespace Domain.Entities;

public record InvitationData(int MemberID, int GatheringID);
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
    internal static Invitation Create(InvitationData data)
    {
        return data;
    }
    public void Confirm()
    {
        InvitationStatus = InvitationStatus.Accepted;
    }
    public void Decline()
    {
        InvitationStatus = InvitationStatus.Declined;
    }

    public static implicit operator InvitationData(Invitation invitation)
    {
        return new InvitationData(invitation.MemberID, invitation.GatheringID);
    }
    public static implicit operator Invitation(InvitationData data)
    {
        return new Invitation(data.MemberID, data.GatheringID);
    }
}

