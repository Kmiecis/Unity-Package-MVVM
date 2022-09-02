using System;

namespace Common.MVVM
{
    public interface IDynamicValue<T>
    {
        T Value { get; }

        event Action<T> OnChange;
    }
}
