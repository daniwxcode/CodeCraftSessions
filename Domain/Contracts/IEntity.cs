using Domain.Primitives;

namespace Domain.Contracts;

public interface IEntity<Tentity, TId, TData>
{
     TId Id { get; set; }
    public abstract Tentity Create(TData data);
}
