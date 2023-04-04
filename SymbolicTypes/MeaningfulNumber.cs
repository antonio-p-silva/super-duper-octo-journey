using System;
using System.Collections.Generic;

namespace ShowIntent.SymbolicTypes
{
    public abstract class MeaningfulNumber<T> : IMeaningfulType<T>, IEquatable<MeaningfulNumber<T>>
    {
        public T Value { get; }

        protected MeaningfulNumber(T value)
        {
            Value = value;
        }

        public static bool operator ==(MeaningfulNumber<T> firstMeaningfulInteger, MeaningfulNumber<T> secondMeaningfulInteger)
        {
            if (firstMeaningfulInteger is null)
            {
                return false;
            }
            return firstMeaningfulInteger.Equals(secondMeaningfulInteger);
        }

        public static bool operator !=(MeaningfulNumber<T> firstMeaningfulInteger, MeaningfulNumber<T> secondMeaningfulInteger)
        {
            return !(firstMeaningfulInteger == secondMeaningfulInteger);
        }

        public bool Equals(MeaningfulNumber<T> other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return EqualityComparer<T>.Default.Equals(Value, other.Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((MeaningfulNumber<T>)obj);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<T>.Default.GetHashCode(Value);
        }
    }
}