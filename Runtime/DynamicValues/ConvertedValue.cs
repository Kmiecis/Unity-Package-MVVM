using System;

namespace Common.MVVM
{
    public static class ConvertedValue
    {
        public static ConvertedValue<TIn, TOut> Create<TIn, TOut>(Func<TIn, TOut> converter, IDynamicValue<TIn> value)
        {
            return new ConvertedValue<TIn, TOut>(converter, value);
        }
    }

    public class ConvertedValue<TIn, TOut> : IDynamicValue<TOut>
    {
        protected readonly Func<TIn, TOut> _converter;
        protected readonly IDynamicValue<TIn> _value;

        protected event Action<TOut> _callback;

        public ConvertedValue(Func<TIn, TOut> converter, IDynamicValue<TIn> value)
        {
            _converter = converter;
            _value = value;
        }

        public TOut Value
        {
            get => GetValue();
        }

        public void AddListener(Action<TOut> callback)
        {
            if (_callback == null)
            {
                _value.AddListener(OnValueChanged);
            }

            _callback += callback;
        }

        public void RemoveListener(Action<TOut> callback)
        {
            _callback -= callback;

            if (_callback == null)
            {
                _value.RemoveListener(OnValueChanged);
            }
        }

        public void RemoveAllListeners()
        {
            _callback = null;
            _value.RemoveListener(OnValueChanged);
        }

        public virtual TOut GetValue()
        {
            return _converter(_value.Value);
        }

        protected void Invoke(TOut value)
        {
            _callback?.Invoke(value);
        }

        protected void Invoke(TIn value)
        {
            Invoke(_converter(value));
        }

        public void Invoke()
        {
            Invoke(_value.Value);
        }

        protected void OnValueChanged(TIn value)
        {
            Invoke(value);
        }

        public static implicit operator TOut(ConvertedValue<TIn, TOut> value)
        {
            return value.Value;
        }

        private bool Equals(ConvertedValue<TIn, TOut> other)
        {
            return (
                other != null &&
                (ReferenceEquals(this, other) || Equals(this.Value, other.Value))
            );
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ConvertedValue<TIn, TOut>);
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}
