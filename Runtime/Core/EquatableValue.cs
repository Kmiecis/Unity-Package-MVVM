using System.Collections.Generic;
using System;

namespace Common.MVVM
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

    public class EquatableValue<T> : DynamicValue<T>
    {
        protected Func<T, T, bool> _equals;

        public EquatableValue()
        {
        }

        public EquatableValue(T value) :
            base(value)
        {
        }

        public EquatableValue(T value, Func<T, T, bool> equals) :
            this(value)
        {
            _equals = equals;
        }

        public EquatableValue(Func<T, T, bool> equals)
        {
            _equals = equals;
        }

        public override void SetValue(T value)
        {
            if (_equals != null)
            {
                if (!_equals(_value, value))
                {
                    base.SetValue(value);
                }
            }
            else
            {
                if (!Equals(_value, value))
                {
                    base.SetValue(value);
                }
            }
        }
    }
}
