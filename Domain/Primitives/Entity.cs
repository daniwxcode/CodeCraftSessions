using Domain.Contracts;

using System.Numerics;

namespace Domain.Primitives;

public abstract class Entity : IEquatable<Entity>
{
    public int Id { get; set; }
    public bool Equals(Entity? other)
    {
       if(other is null)
        {
            return false;
        }
       if(other.GetType() != GetType())
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


public abstract class AggregateRoot<TEntity, TData> : Entity, IEntity<TEntity, int, TData> where TEntity : AggregateRoot<TEntity, TData>
{
    public abstract TEntity Create(TData data);

    public bool Equals(AggregateRoot<TEntity, TData>? other)
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

    public static bool operator ==(AggregateRoot<TEntity, TData> left, AggregateRoot<TEntity, TData> right) => left is not null && right is not null && left.Equals(right);
    public static bool operator !=(AggregateRoot<TEntity, TData> left, AggregateRoot<TEntity, TData> right) => !(left == right);   

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
