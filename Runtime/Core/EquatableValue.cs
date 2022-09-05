using System.Collections.Generic;
using System;

namespace Common.MVB
{
    public static class EquatableValue
    {
        public static EquatableValue<T> Create<T>()
        {
            return new EquatableValue<T>();
        }

        public static EquatableValue<T> Create<T>(T value)
        {
            return new EquatableValue<T>(value);
        }

        public static EquatableValue<T> Create<T>(T value, Func<T, T, bool> equals)
        {
            return new EquatableValue<T>(value, equals);
        }

        public static EquatableValue<T> Create<T>(Func<T, T, bool> equals)
        {
            return new EquatableValue<T>(equals);
        }

        public static EquatableValue<T> Create<T>(T value, IEqualityComparer<T> comparer)
        {
            return new EquatableValue<T>(value, comparer.Equals);
        }

        public static EquatableValue<T> Create<T>(IEqualityComparer<T> comparer)
        {
            return new EquatableValue<T>(comparer.Equals);
        }
    }

    [Serializable]
    public class EquatableValue<T> : DynamicValue<T>
    {
        public readonly Func<T, T, bool> _equals;

        public EquatableValue(T value, Func<T, T, bool> equals) :
            base(value)
        {
            _equals = equals;
        }

        public EquatableValue(T value) :
            this(value, EqualityComparer<T>.Default.Equals)
        {
        }

        public EquatableValue(Func<T, T, bool> equals)
        {
            _equals = equals;
        }

        public EquatableValue() :
            this(EqualityComparer<T>.Default.Equals)
        {
        }

        public override void SetValue(T value)
        {
            if (!_equals(_value, value))
            {
                base.SetValue(value);
            }
        }

        private bool Equals(EquatableValue<T> other)
        {
            return (
                other != null &&
                (
                    ReferenceEquals(this, other) ||
                    this._equals == other._equals ?
                        this._equals(this.Value, other.Value) :
                        this._equals(this.Value, other.Value) && other._equals(other.Value, this.Value)
                )
            );
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as EquatableValue<T>);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
