using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(DoubleObject), fileName = nameof(DoubleObject))]
    public class DoubleObject : DynamicObject<double>
    {
    }
}
