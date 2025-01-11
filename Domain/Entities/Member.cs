using Domain.Primitives;

using System.Data.Common;

namespace Domain.Entities
{
    public record MemberData(int Id, string FirstName, string Name, string Email);
   

    public class Member : Entity
    {
        public string FirstName { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }

        private Member() { }
        private Member(int id,string firstName, string name, string email)
        {
            Id = id;
            FirstName = firstName;
            Name = name;
            Email = email;
        }
        public static Member Create(MemberData data)
        {
            return data;            
        }
        public static implicit operator MemberData(Member member)
        {
            return new MemberData(member.Id, member.FirstName, member.Name, member.Email);
        }
        public static implicit operator Member(MemberData data)
        {
            return new Member(data.Id, data.FirstName, data.Name, data.Email);
        }
    }
}
