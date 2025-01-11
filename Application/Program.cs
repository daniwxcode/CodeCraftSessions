
using Domain.Entities;
Member member = Member.Create(1,"John", "Doe","john@Doe.com");
Gathering gathering = Gathering.Create("John", "Birthday Party");
gathering.AddInvitation(member);
gathering.AddInvitation(member);
gathering.AddInvitation(member);
gathering.AddInvitation(member);
gathering.AddInvitation(member);
gathering.AddInvitation(member);
gathering.AddInvitation(member);
Console.WriteLine(gathering.Invitations.Count);
Console.WriteLine(gathering.Capacity.Value);

Console.ReadLine();