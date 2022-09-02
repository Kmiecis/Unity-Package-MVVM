using System;
using UnityEngine;

namespace Common.MVVM
{
    public class DynamicObject<T> : ScriptableObject, IDynamicValue<T>
    {
        [SerializeReference]
        protected T _value;
        protected event Action<T> _callback;

        public T Value
        {
            get => GetValue();
            set => SetValue(value);
        }

        public virtual T GetValue()
        {
            return _value;
        }

        public virtual void SetValue(T value)
        {
            _callback?.Invoke(value);
            _value = value;
        }

        public event Action<T> OnChange
        {
            add
            {
                _callback += value;
                value(_value);
            }
            remove
            {
                _callback -= value;
            }
        }

        public static implicit operator T(DynamicObject<T> value)
        {
            return value.Value;
        }
    }
}
