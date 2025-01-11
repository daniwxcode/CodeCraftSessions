namespace Domain.Primitives;

public abstract class Entity : IEquatable<Entity>
{
    protected int Id { get; set; }
    public bool Equals(Entity? other)
    {
        if (other is null)
        {
            return false;
        }
        if (other.GetType() != GetType())
        {
            return false;
        }
        return Id == other.Id;
    }
    public static bool operator ==(Entity left, Entity right) => left is not null && right is not null && left.Equals(right);
    public static bool operator !=(Entity left, Entity right) => !(left == right);

    public override bool Equals(object obj)
    {
        if (obj is null)
        {
            return false;
        }
        if (obj.GetType() != GetType())
        {
            return false;
        }
        if (obj is not Entity entity)
        {
            return false;
        }
        return Id == entity.Id;
    }
    public override int GetHashCode() => Id.GetHashCode();

}
