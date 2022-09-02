using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(Vector2Object), fileName = nameof(Vector2Object))]
    public class Vector2Object : DynamicObject<Vector2>
    {
    }
}
