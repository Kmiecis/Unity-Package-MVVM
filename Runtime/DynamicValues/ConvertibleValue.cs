using System;

namespace Common.MVVM
{
    public static class ConvertibleValue
    {
        public static ConvertibleValue<TIn, TOut> Create<TIn, TOut>(Func<TIn, TOut> converter, IDynamicValue<TIn> value)
        {
            return new ConvertibleValue<TIn, TOut>(converter, value);
        }
    }

    public class ConvertibleValue<TIn, TOut> : IDynamicValue<TOut>
    {
        protected Func<TIn, TOut> _converter;
        protected IDynamicValue<TIn> _value;

        protected event Action<TOut> _callback;

        public ConvertibleValue(Func<TIn, TOut> converter, IDynamicValue<TIn> value)
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

        private bool Equals(ConvertibleValue<TIn, TOut> other)
        {
            return Equals(this.Value, other.Value);
        }

        public static implicit operator TOut(ConvertibleValue<TIn, TOut> value)
        {
            return value.Value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            if (ReferenceEquals(obj, null))
                return false;

            if (this.GetType() != obj.GetType())
                return false;

            return Equals((ConvertibleValue<TIn, TOut>)obj);
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
