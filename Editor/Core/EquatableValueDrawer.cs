using Common.MVVM;
using UnityEditor;

namespace CommonEditor.MVVM
{
    [CustomPropertyDrawer(typeof(EquatableValue<>))]
    public class EquatableValueDrawer : DynamicValueDrawer
    {
    }
}
