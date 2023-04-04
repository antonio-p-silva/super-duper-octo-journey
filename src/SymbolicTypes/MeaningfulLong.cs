namespace ShowIntent.SymbolicTypes
{
    public abstract class MeaningfulLong : MeaningfulNumber<long>
    {
        protected MeaningfulLong(long value) : base(value)
        {
        }
    }
}