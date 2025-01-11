namespace Domain.Primitives;

public abstract class ValueObject: IEquatable<ValueObject>
{
    public abstract IEnumerable<Object> GetAtomicsValues();
    public bool Equals(ValueObject? other)
    {
       return other is not null && ValuesAresEquals(other);
    }

    private bool ValuesAresEquals(ValueObject other)
    {
        return GetAtomicsValues().SequenceEqual(other.GetAtomicsValues());
    }
    public override bool Equals(object obj)
    {
        return obj is ValueObject other &&  ValuesAresEquals(other);
    }
}
