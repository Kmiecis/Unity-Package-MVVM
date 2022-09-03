using Common.MVB;
using UnityEditor;

namespace CommonEditor.MVB
{
    [CustomPropertyDrawer(typeof(EquatableValue<>))]
    public class EquatableValueDrawer : DynamicValueDrawer
    {
    }
}
