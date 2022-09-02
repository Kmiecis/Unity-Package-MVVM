using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(Vector4Object), fileName = nameof(Vector4Object))]
    public class Vector4Object : DynamicObject<Vector4>
    {
    }
}
