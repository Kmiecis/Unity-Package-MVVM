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
    }

    [Serializable]
    public class EquatableValue<T> : DynamicValue<T>
    {
        public EquatableValue() :
            base()
        {
        }

        public EquatableValue(T value) :
            base(value)
        {
        }

        public override void SetValue(T value)
        {
            if (!Equals(_value, value))
            {
                base.SetValue(value);
            }
        }
    }
}
