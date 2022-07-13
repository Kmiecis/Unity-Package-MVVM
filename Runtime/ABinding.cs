namespace Common.MVVM
{
    public abstract class ABinding<TTarget, TValue> : IBinding
    {
        protected readonly TTarget _target;
        protected readonly DynamicValue<TValue> _value;

        public ABinding(TTarget target, DynamicValue<TValue> value)
        {
            _target = target;
            _value = value;
        }

        public abstract void OnValueChanged(TValue value);

        public void Attach()
        {
            _value.OnChange += OnValueChanged;
        }

        public void Detach()
        {
            _value.OnChange -= OnValueChanged;
        }
    }
}
