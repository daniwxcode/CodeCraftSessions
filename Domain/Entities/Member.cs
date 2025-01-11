using Domain.Primitives;

using System.Data.Common;

namespace Domain.Entities
{
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
        public static Member Create(int id, string firstName, string name, string email)
        {
            return new Member(id, firstName, name, email);
            
        }
    }
}
