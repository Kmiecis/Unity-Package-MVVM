using System;

namespace Common.MVB
{
    public interface IDynamicValue<T> : IInvokeable
    {
        T Value { get; }

        event Action<T> OnChange;
    }
}
