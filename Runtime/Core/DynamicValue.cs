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

        protected bool _set;

        public DynamicValue()
        {
        }

        public DynamicValue(T value)
        {
            SetValue(value);
        }

        public bool IsSet
        {
            get => _set;
        }

        public T Value
        {
            get => GetValue();
            set => SetValue(value);
        }

        public void AddListener(Action<T> callback)
        {
            _callback += callback;

            if (_set)
            {
                callback(_value);
            }
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
            _value = value;
            _set = true;

            Invoke();
        }

        public void Invoke()
        {
            _callback?.Invoke(_value);
        }

        public static implicit operator T(DynamicValue<T> value)
        {
            return value.Value;
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

        public bool IsSet
        {
            get => _value.IsSet;
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

            if (IsSet)
            {
                callback(Value);
            }
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

        private void OnValueChanged(TIn value)
        {
            _callback.Invoke(_converter(value));
        }

        public void Invoke()
        {
            _callback?.Invoke(_converter(_value));
        }

        public static implicit operator TOut(DynamicValue<TIn, TOut> value)
        {
            return value.Value;
        }
    }
}
