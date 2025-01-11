using Domain.ValueObjects;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Gathering
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
        public static Gathering Create(string host, string @object)
        {
            return new Gathering
            {
                Host = host,
                Object = @object
            };
        }
        public void AddInvitation(Member member)
        {
            // checkig Invitation already exists and pending
            var invitation = Invitation.Create(member.Id, Id);
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
    }
}
