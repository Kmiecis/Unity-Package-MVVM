using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(DoubleObject), fileName = nameof(DoubleObject))]
    public class DoubleObject : DynamicObject<double>
    {
    }
}
