using System;

namespace Common.MVVM
{
    public static class Binding
    {
        public static Binding<T> Create<T>(IDynamicValue<T> value, Action<T> target)
        {
            return new Binding<T>(value, target);
        }
    }

    public class Binding<T> : IBinding
    {
        private readonly IDynamicValue<T> _value;
        private readonly Action<T> _target;

        public Binding(IDynamicValue<T> value, Action<T> target)
        {
            _value = value;
            _target = target;
        }

        public void Attach()
        {
            _value.AddListener(_target);
            _target(_value.Value);
        }

        public void Detach()
        {
            _value.RemoveListener(_target);
        }
    }
}
