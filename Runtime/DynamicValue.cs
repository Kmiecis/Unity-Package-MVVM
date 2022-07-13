using System;

namespace Common.MVVM
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

        public static DynamicValue<TIn, TOut> Create<TIn, TOut>(Func<TIn, TOut> converter)
        {
            return Create(converter, Create<TIn>());
        }
    }

    public class DynamicValue<T> : IDynamicValue<T>
    {
        protected T _value;
        protected event Action<T> _callback;

        private bool _set;

        public DynamicValue()
        {
        }

        public DynamicValue(T value)
        {
            SetValue(value);
        }

        public event Action<T> OnChange
        {
            add
            {
                _callback += value;

                if (_set)
                {
                    value(_value);
                }
            }
            remove
            {
                _callback -= value;
            }
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

        public T GetValue()
        {
            return _value;
        }

        public void SetValue(T value)
        {
            _callback?.Invoke(value);

            _value = value;
            _set = true;
        }

        public static implicit operator T(DynamicValue<T> value)
        {
            return value.Value;
        }
    }

    public class DynamicValue<TIn, TOut> : IDynamicValue<TOut>
    {
        private readonly Func<TIn, TOut> _converter;
        private DynamicValue<TIn> _value;
        private event Action<TOut> _callback;

        public DynamicValue(Func<TIn, TOut> converter, DynamicValue<TIn> value)
        {
            _converter = converter;
            _value = value;
        }

        public event Action<TOut> OnChange
        {
            add
            {
                _callback += value;

                if (IsSet)
                {
                    value(Value);
                }
            }
            remove
            {
                _callback -= value;
            }
        }

        public bool IsSet
        {
            get => _value.IsSet;
        }

        public TOut Value
        {
            get => _converter(_value);
        }

        public static implicit operator TOut(DynamicValue<TIn, TOut> value)
        {
            return value.Value;
        }
    }
}
