using System;

namespace ShowIntent.SymbolicTypes
{
    public abstract class MeaningfulGuid : IMeaningfulType<Guid>
    {
        public abstract Guid Value { get; }

        public static bool operator ==(MeaningfulGuid first, MeaningfulGuid second)
        {
            if (first is null)
            {
                return false;
            }
            return first.Equals(second);
        }

        public static bool operator !=(MeaningfulGuid first, MeaningfulGuid second)
        {
            return !(first == second);
        }

        public bool Equals(MeaningfulGuid other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Value == other.Value && this.GetType() == other.GetType();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((MeaningfulGuid)obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }

    public abstract class MeaningfulInt : IMeaningfulType<int>
    {
        public abstract int Value { get; }

        public static bool operator ==(MeaningfulInt first, MeaningfulInt second)
        {
            if (first is null)
            {
                return false;
            }
            return first.Equals(second);
        }

        public static bool operator !=(MeaningfulInt first, MeaningfulInt second)
        {
            return !(first == second);
        }

        public bool Equals(MeaningfulInt other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Value == other.Value && this.GetType() == other.GetType();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((MeaningfulInt)obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}