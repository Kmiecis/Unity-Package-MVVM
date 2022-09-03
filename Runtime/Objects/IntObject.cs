using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(IntObject), fileName = nameof(IntObject))]
    public sealed class IntObject : DynamicObject<int>
    {
    }
}
