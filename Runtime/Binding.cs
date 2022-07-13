using System;

namespace Common.MVVM
{
    public static class Binding
    {
        public static Binding<T> Create<T>(Action<T> target, IDynamicValue<T> value)
        {
            return new Binding<T>(target, value);
        }
    }

    public class Binding<T> : IBinding
    {
        protected readonly Action<T> _target;
        protected readonly IDynamicValue<T> _value;

        public Binding(Action<T> target, IDynamicValue<T> value)
        {
            _target = target;
            _value = value;
        }

        public void Attach()
        {
            _value.OnChange += _target;
        }

        public void Detach()
        {
            _value.OnChange -= _target;
        }
    }
}
