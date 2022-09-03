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

        public void AddListener(Action<T> callback)
        {
            _callback += callback;
            callback(_value);
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
