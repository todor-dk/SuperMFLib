using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Core;

namespace MediaFoundation
{
    /// <summary>
    /// Represents time / timespan in the Media Foundation framework.
    /// One tick / unit equals 100 nanoseconds, i.e. 1 seconds equals 10000000.
    /// </summary>
    /// <remarks>
    /// See: http://msdn.microsoft.com/en-us/library/windows/desktop/dd979590(v=vs.85).aspx
    /// </remarks>
    public struct Time : IEquatable<Time>, IComparable<Time>
    {
        /// <summary>
        /// Represents time / timespan in the Media Foundation framework.
        /// One tick / unit equals 100 nanoseconds, i.e. 1 seconds equals 10000000.
        /// </summary>
        public long Value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Time"/> struct.
        /// </summary>
        /// <param name="value">The time value in 100 nanosecond units.</param>
        public Time(long value)
            : this()
        {
            this.Value = value;
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">Another object to compare to.</param>
        /// <returns>true if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, false.</returns>
        public override bool Equals(Object obj)
        {
            return (obj is Time) && this.Equals((Time)obj);
        }

        /// <summary>
        /// Indicates whether this instance and a specified instance are equal.
        /// </summary>
        /// <param name="other">Another <see cref="Time"/> to compare to.</param>
        /// <returns>true if <paramref name="other" /> and this instance are the same type and represent the same value; otherwise, false.</returns>
        public bool Equals(Time other)
        {
            return (this.Value == other.Value);
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
        /// Compares the current instance to another instance to determine whether they are equal.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(Time left, Time right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares the current instance to another instance to determine whether they are different.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(Time left, Time right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Performs an explicit conversion from <see cref="System.Int64"/> to <see cref="Time"/>.
        /// </summary>
        /// <param name="value">The time value in 100 nanosecond units.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Time(long value)
        {
            return new Time(value);
        }

        /// <summary>
        /// Performs an explicit conversion from <see cref="Time"/> to <see cref="System.Int64"/>.
        /// </summary>
        /// <param name="time">The time value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator long(Time time)
        {
            return time.Value;
        }

        /// <summary>
        /// Performs an explicit conversion from <see cref="TimeSpan"/> to <see cref="Time"/>.
        /// </summary>
        /// <param name="value">A time interval.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Time(TimeSpan value)
        {
            // One tick equals 100 nanoseconds.
            // Each unit of reference time is 100 nanoseconds.
            return new Time(value.Ticks);
        }

        /// <summary>
        /// Performs an explicit conversion from <see cref="Time"/> to <see cref="TimeSpan"/>.
        /// </summary>
        /// <param name="time">The time value to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator TimeSpan(Time time)
        {
            return new TimeSpan(time.Value);
        }

        /// <summary>
        /// Gets or sets the time represented as a time interval.
        /// </summary>
        public TimeSpan TimeSpan
        {
            get { return new TimeSpan(this.Value); }
            set { this.Value = value.Ticks; }
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return this.TimeSpan.ToString();
        }

        #region Constants

        /// <summary>
        /// <see cref="Time"/> representing a zero duration.
        /// </summary>
        public static readonly Time Zero = new Time();

        /// <summary>
        /// Represents the largest (latest) possible value of a <see cref="Time"/>.
        /// </summary>
        public static readonly Time MaximumValue = new Time(Int64.MaxValue);

        /// <summary>
        /// Represents the smallest (earliest) possible value of a <see cref="Time"/>.
        /// </summary>
        public static readonly Time MinimumValue = new Time(Int64.MinValue);

        /// <summary>
        /// <see cref="Time"/> representing the duration of 1 second.
        /// </summary>
        public static readonly Time OneSecond = new Time(Time.OneSecondValue);

        /// <summary>
        /// <see cref="Time"/> representing the duration of 1 millisecond.
        /// </summary>
        public static readonly Time OneMillisecond = new Time(Time.OneMillisecondValue);

        /// <summary>
        /// The <see cref="Value"/> of a <see cref="Time"/> with the duration of 1 second.
        /// </summary>
        public const long OneSecondValue = 10000000;

        /// <summary>
        /// The <see cref="Value"/> of a <see cref="Time"/> with the duration of 0.5 seconds.
        /// </summary>
        public const long HalfSecondValue = 5000000;

        /// <summary>
        /// The <see cref="Value"/> of a <see cref="Time"/> with the duration of 1 second.
        /// </summary>
        public const long OneMillisecondValue = 10000;

        /// <summary>
        /// The <see cref="Value"/> of a <see cref="Time"/> with the duration of 0.5 seconds.
        /// </summary>
        public const long HalfMillisecondValue = 5000;

        #endregion

        #region Operators

        /// <summary>
        /// Adds the given times.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand</param>
        /// <returns>Returns the sum of the given time operands.</returns>
        public static Time operator +(Time left, Time right)
        {
            return new Time(left.Value + right.Value);
        }

        /// <summary>
        /// Adds the given times.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand</param>
        /// <returns>Returns the sum of the given time operands.</returns>
        public static Time operator +(Time left, long right)
        {
            return new Time(left.Value + right);
        }

        /// <summary>
        /// Adds the given times.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand</param>
        /// <returns>Returns the sum of the given time operands.</returns>
        public static Time operator +(long left, Time right)
        {
            return new Time(left + right.Value);
        }

        /// <summary>
        /// Subtracts the given times.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand</param>
        /// <returns>Returns the difference of the given time operands.</returns>
        public static Time operator -(Time left, Time right)
        {
            return new Time(left.Value - right.Value);
        }

        /// <summary>
        /// Subtracts the given times.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand</param>
        /// <returns>Returns the difference of the given time operands.</returns>
        public static Time operator -(Time left, long right)
        {
            return new Time(left.Value - right);
        }

        /// <summary>
        /// Subtracts the given times.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand</param>
        /// <returns>Returns the difference of the given time operands.</returns>
        public static Time operator -(long left, Time right)
        {
            return new Time(left - right.Value);
        }

        /// <summary>
        /// Multiplies the given time with the given factor.
        /// </summary>
        /// <param name="time">Time to be multiplied.</param>
        /// <param name="factor">Factor to multiply the time with.</param>
        /// <returns>Returns the product of the given time and factor.</returns>
        public static Time operator *(Time time, long factor)
        {
            return new Time(time.Value * factor);
        }

        /// <summary>
        /// Multiplies the given time with the given factor.
        /// </summary>
        /// <param name="factor">Factor to multiply the time with.</param>
        /// <param name="time">Time to be multiplied.</param>
        /// <returns>Returns the product of the given time and factor.</returns>
        public static Time operator *(long factor, Time time)
        {
            return new Time(time.Value * factor);
        }

        /// <summary>
        /// Divide the given time with the given divisor.
        /// </summary>
        /// <param name="time">Time to be divided.</param>
        /// <param name="divisor">Divisor to divide the time with.</param>
        /// <returns>Returns the quotient of the given time and divisor.</returns>
        public static Time operator /(Time time, long divisor)
        {
            return new Time(time.Value / divisor);
        }

        /// <summary>
        /// Negate the given time.
        /// </summary>
        /// <param name="time">Time to be negated.</param>
        /// <returns>Returns a new time with a negated value of the given time.</returns>
        public static Time operator -(Time time)
        {
            return new Time(-time.Value);
        }

        /// <summary>
        /// Compares if the <paramref name="left"/> <see cref="Time"/> operand
        /// is lower than the <paramref name="right"/> <see cref="Time"/> operand.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>The result of the lower than operator.</returns>
        public static bool operator <(Time left, Time right)
        {
            return left.Value < right.Value;
        }

        /// <summary>
        /// Compares if the <paramref name="left"/> <see cref="Time"/> operand
        /// is lower than or equal the <paramref name="right"/> <see cref="Time"/> operand.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>The result of the lower than or equals operator.</returns>
        public static bool operator <=(Time left, Time right)
        {
            return left.Value <= right.Value;
        }

        /// <summary>
        /// Compares if the <paramref name="left"/> <see cref="Time"/> operand
        /// is greather than the <paramref name="right"/> <see cref="Time"/> operand.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>The result of the greather than operator.</returns>
        public static bool operator >(Time left, Time right)
        {
            return left.Value > right.Value;
        }

        /// <summary>
        /// Compares if the <paramref name="left"/> <see cref="Time"/> operand
        /// is greather than or equal the <paramref name="right"/> <see cref="Time"/> operand.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>The result of the greather than or equals operator.</returns>
        public static bool operator >=(Time left, Time right)
        {
            return left.Value >= right.Value;
        }

        #endregion

        /// <summary>
        /// Compares the current object with another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other" /> parameter.Zero This object is equal to <paramref name="other" />. Greater than zero This object is greater than <paramref name="other" />.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int CompareTo(Time other)
        {
            return this.Value.CompareTo(other.Value);
        }

        /// <summary>
        /// Returns the system time.
        /// </summary>
        public static Time SystemTime
        {
            get { return new Time(MFExtern.MFGetSystemTime()); }
        }
    }
}
