using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(Vector2IntObject), fileName = nameof(Vector2IntObject))]
    public class Vector2IntObject : DynamicObject<Vector2Int>
    {
    }
}
