using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(Vector2IntObject), fileName = nameof(Vector2IntObject))]
    public class Vector2IntObject : DynamicObject<Vector2Int>
    {
    }
}
