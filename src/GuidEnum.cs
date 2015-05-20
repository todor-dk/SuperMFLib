using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFoundation
{
    public class GuidEnum : IEquatable<GuidEnum>, IComparable<GuidEnum>, IEquatable<Guid>, IComparable<Guid>
    {
        public Guid Value { get; private set; }

        public GuidEnum(Guid value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">Another object to compare to.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is GuidEnum))
                return false;

            return Equals((GuidEnum)obj);
        }
    
        public bool Equals(GuidEnum other)
        {
            if (other == null)
                return false;
            return this.Value.Equals(other.Value);
        }

        public int CompareTo(GuidEnum other)
        {
            if (other == null)
                return 1;
            return this.Value.CompareTo(other.Value);
        }

        public bool Equals(Guid other)
        {
            return this.Value.Equals(other);
        }

        public int CompareTo(Guid other)
        {
            return this.Value.CompareTo(other);
        }

        /// <summary>
        /// Compares whether the left GuidEnum operand is equal to the right GuidEnum operand. 
        /// </summary>
        /// <param name="left">The left GuidEnum operand.</param>
        /// <param name="right">The right GuidEnum operand.</param>
        /// <returns>The result of the equality operator.</returns>
        public static bool operator ==(GuidEnum left, GuidEnum right)
        {
            if (Object.ReferenceEquals(left, null) && Object.ReferenceEquals(right, null))
                return true;
            if (Object.ReferenceEquals(left, null) || Object.ReferenceEquals(right, null))
                return false;
            return left.Equals(right);
        }

        /// <summary>
        /// Compares whether the left GuidEnum operand is not equal to the right GuidEnum operand. 
        /// </summary>
        /// <param name="left">The left GuidEnum operand.</param>
        /// <param name="right">The right GuidEnum operand.</param>
        /// <returns>The result of the inequality operator.</returns>
        public static bool operator !=(GuidEnum left, GuidEnum right)
        {
            if (Object.ReferenceEquals(left, null) && Object.ReferenceEquals(right, null))
                return false;
            if (Object.ReferenceEquals(left, null) || Object.ReferenceEquals(right, null))
                return true;

            return !left.Equals(right);
        }

        public static implicit operator Guid(GuidEnum self)
        {
            if (self == null)
                return Guid.Empty;
            return self.Value;
        }
    }
}
