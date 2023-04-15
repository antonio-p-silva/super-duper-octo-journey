namespace ShowIntent.SymbolicTypes
{
    public interface IMeaningfulType<out T>
    {
        T Value { get; }
    }
}