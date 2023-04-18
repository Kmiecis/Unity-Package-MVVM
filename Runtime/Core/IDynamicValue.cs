using System;

namespace Common.MVVM
{
    public interface IDynamicValue<T> : IInvokeable
    {
        T Value { get; }

        void AddListener(Action<T> callback);

        void RemoveListener(Action<T> callback);

        void RemoveAllListeners();
    }
}
