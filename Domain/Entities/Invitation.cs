using Domain.Enums;

namespace Domain.Entities;

public class Invitation
{
    public int MemberID { get; private set; }
    public int GatheringID { get; private set; }
    public InvitationStatus InvitationStatus { get; private set; }    
}

