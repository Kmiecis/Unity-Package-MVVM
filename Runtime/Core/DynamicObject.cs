using System;
using UnityEngine;

namespace Common.MVB
{
    public class DynamicObject<T> : ScriptableObject, IDynamicValue<T>
    {
        [SerializeField]
        protected T _value;
        protected event Action<T> _callback;

        public T Value
        {
            get => GetValue();
            set => SetValue(value);
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

        public virtual T GetValue()
        {
            return _value;
        }

        public virtual void SetValue(T value)
        {
            _value = value;

            Invoke();
        }

        public void Invoke()
        {
            _callback?.Invoke(_value);
        }

        public static implicit operator T(DynamicObject<T> value)
        {
            return value.Value;
        }
    }
}
