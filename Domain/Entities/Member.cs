using Domain.Primitives;

namespace Domain.Entities
{
    public class Member : Entity
    {
        public string FirstName { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }

    }
}
