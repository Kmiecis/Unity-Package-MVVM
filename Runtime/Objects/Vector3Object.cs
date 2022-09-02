using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(Vector3Object), fileName = nameof(Vector3Object))]
    public class Vector3Object : DynamicObject<Vector3>
    {
    }
}
