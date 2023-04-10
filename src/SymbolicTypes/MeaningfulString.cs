using System;
using System.Collections.Generic;

namespace ShowIntent.SymbolicTypes
{
    public abstract class MeaningfulString : IEquatable<MeaningfulString>, IMeaningfulType<string>
    {
        public virtual string Value { get; }
        
        protected MeaningfulString(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Cannot be null or empty string",nameof(value));
            }

            Value = value;
        }
        
        public static bool operator ==(MeaningfulString firstMeaningfulString, MeaningfulString secondMeaningfulString)
        {
            if (firstMeaningfulString is null)
            {
                return false;
            }
            return firstMeaningfulString.Equals(secondMeaningfulString);
        }

        public static bool operator !=(MeaningfulString firstMeaningfulString, MeaningfulString secondMeaningfulString)
        {
            return !(firstMeaningfulString == secondMeaningfulString);
        }

        public bool Equals(MeaningfulString other)
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
            return Equals((MeaningfulString)obj);
        }

        public override int GetHashCode()
        {
            return (Value != null ? Value.GetHashCode() : 0);
        }
    }
}