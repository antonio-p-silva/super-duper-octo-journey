namespace ShowIntent.SymbolicTypes
{
    public abstract class MeaningfulInteger : MeaningfulNumber<int>
    {
        protected MeaningfulInteger(int value) : base(value)
        {
        }
    }
}