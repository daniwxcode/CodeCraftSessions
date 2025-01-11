using Domain.Primitives;

namespace Domain.Entities;

public class Guest : Entity
{
    public int MemberId { get; private set; }
    public int GatheringId { get; private set; }

    private Guest() { }

    private Guest(int memberId, int gatheringId)
    {
        MemberId = memberId;
        GatheringId = gatheringId;
    }
    internal static Guest Create(int memberId, int gatheringId)
    {
        return new Guest
        {
            MemberId = memberId,
            GatheringId = gatheringId
        };
    }
}
