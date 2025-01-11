namespace Domain.Contracts;

public interface IValueObject<T>
{
    static abstract T Default { get; }
}
