using Domain.Primitives;

namespace Domain.Entities;

public record GuestData(int MemberId, int GatheringId);
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
    internal static Guest Create(GuestData guestData)
    {
        return guestData;
    }

    public static implicit operator Guest(GuestData data)
    {
        return new Guest(data.MemberId, data.GatheringId);
    }
    public static implicit operator GuestData(Guest guest)
    {
        return new GuestData(guest.MemberId, guest.GatheringId);
    }
}
