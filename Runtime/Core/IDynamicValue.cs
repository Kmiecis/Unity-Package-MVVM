using System;

namespace Common.MVB
{
    public interface IDynamicValue<T>
    {
        T Value { get; }

        event Action<T> OnChange;
    }
}
