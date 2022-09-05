using System;
using UnityEngine;

namespace Common.MVB
{
    public static class DynamicValue
    {
        public static DynamicValue<T> Create<T>()
        {
            return new DynamicValue<T>();
        }

        public static DynamicValue<T> Create<T>(T value)
        {
            return new DynamicValue<T>(value);
        }

        public static DynamicValue<TIn, TOut> Create<TIn, TOut>(Func<TIn, TOut> converter, DynamicValue<TIn> value)
        {
            return new DynamicValue<TIn, TOut>(converter, value);
        }
    }

    [Serializable]
    public class DynamicValue<T> : IDynamicValue<T>
    {
        [SerializeField]
        protected T _value;
        protected event Action<T> _callback;

        public DynamicValue()
        {
        }

        public DynamicValue(T value)
        {
            SetValue(value);
        }

        public T Value
        {
            get => GetValue();
            set => SetValue(value);
        }

        public void AddListener(Action<T> callback)
        {
            _callback += callback;
        }

        public void RemoveListener(Action<T> callback)
        {
            _callback -= callback;
        }

        public void RemoveAllListeners()
        {
            _callback = null;
        }

        public virtual T GetValue()
        {
            return _value;
        }

        public virtual void SetValue(T value)
        {
            Invoke(value);

            _value = value;
        }

        protected void Invoke(T value)
        {
            _callback?.Invoke(value);
        }

        public void Invoke()
        {
            Invoke(_value);
        }

        public static implicit operator T(DynamicValue<T> value)
        {
            return value.Value;
        }

        private bool Equals(DynamicValue<T> other)
        {
            return (
                other != null &&
                (ReferenceEquals(this, other) || Equals(this.Value, other.Value))
            );
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as DynamicValue<T>);
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

    public class DynamicValue<TIn, TOut> : IDynamicValue<TOut>
    {
        protected readonly Func<TIn, TOut> _converter;

        protected DynamicValue<TIn> _value;
        protected event Action<TOut> _callback;

        public DynamicValue(Func<TIn, TOut> converter, DynamicValue<TIn> value)
        {
            _converter = converter;
            _value = value;
        }

        public TOut Value
        {
            get => _converter(_value);
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
            Invoke(_value);
        }

        protected void OnValueChanged(TIn value)
        {
            Invoke(value);
        }

        public static implicit operator TOut(DynamicValue<TIn, TOut> value)
        {
            return value.Value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}
