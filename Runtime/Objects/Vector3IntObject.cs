using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(Vector3IntObject), fileName = nameof(Vector3IntObject))]
    public class Vector3IntObject : DynamicObject<Vector3Int>
    {
    }
}
