
using Domain.Entities;
Member member = new MemberData(1,"John", "Doe","john@Doe.com");

GatheringData data = new GatheringData("John", "Birthday Party");
Gathering gathering = data;
GatheringData dto = gathering;
gathering.AddInvitation(member);
Console.WriteLine(gathering.Invitations.Count);
Console.WriteLine(gathering.Capacity.Value);

Console.ReadLine();