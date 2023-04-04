namespace ShowIntent.SymbolicTypes
{
    public abstract class MeaningfulShort : MeaningfulNumber<short>
    {
        protected MeaningfulShort(short value) : base(value)
        {
        }
    }
}