using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(FloatObject), fileName = nameof(FloatObject))]
    public sealed class FloatObject : DynamicObject<float>
    {
    }
}
