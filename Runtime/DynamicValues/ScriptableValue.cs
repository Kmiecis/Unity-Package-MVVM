using System;
using UnityEngine;

namespace Common.MVVM
{
    public static class ScriptableValue
    {
        public static ScriptableValue<T> Create<T>()
        {
            return ScriptableObject.CreateInstance<ScriptableValue<T>>();
        }

        public static ScriptableValue<T> Create<T>(T value)
        {
            var result = Create<T>();
            result.SetValue(value);
            return result;
        }
    }

    public class ScriptableValue<T> : ScriptableObject, IDynamicValue<T>
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

        public static implicit operator T(ScriptableValue<T> value)
        {
            return value.Value;
        }

        public static explicit operator ScriptableValue<T>(T value)
        {
            return ScriptableValue.Create(value);
        }

        public bool Equals(ScriptableValue<T> other)
        {
            return Equals(this.Value, other.Value);
        }

        public override bool Equals(object obj)
        {
            return (
                ReferenceEquals(this, obj) ||
                (obj is ScriptableValue<T> other && Equals(other))
            );
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
