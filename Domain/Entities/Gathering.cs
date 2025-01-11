using Domain.Primitives;
using Domain.ValueObjects;

namespace Domain.Entities;


public record GatheringData(string Host, string Object);
public class Gathering: AggregateRoot<Gathering,GatheringData>
{
    public int Id { get; private set; }
    public string Host { get; private set; }
    public string Object { get; private set; }
    public Capacity Capacity { get; private set; } = Capacity.Default;

    private List<Invitation> _invitations = new();
    public List<Guest> _guests = new();
    public IReadOnlyCollection<Invitation> Invitations => _invitations.AsReadOnly();
    public IReadOnlyCollection<Guest> Guests => _guests.AsReadOnly();

    private Gathering() { }

    private Gathering(string host, string @object)
    {
        Host = host;
        Object = @object;
    }
   
    public void AddInvitation(Member member)
    {
        // checkig Invitation already exists and pending
        InvitationData data =new(member.Id,Id);
        var invitation = Invitation.Create(data);
        _invitations.Add(invitation);
    }
    public void ConfirmInvitation(int memberId)
    {
        var invitation = _invitations.FirstOrDefault(i => i.MemberID == memberId);
        if (invitation is null)
            throw new InvalidOperationException("Invitation not found");
        invitation.Confirm();

        // todo Implement Guest creation
    }

    public override Gathering Create(GatheringData data)
    {
        return data;
    }

    public static implicit operator GatheringData(Gathering gathering)
    {
        return new GatheringData(gathering.Host, gathering.Object);
    }
    public static implicit operator Gathering(GatheringData data)
    {
        return new Gathering(data.Host, data.Object);
    }

}
