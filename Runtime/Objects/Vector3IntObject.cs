using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(Vector3IntObject), fileName = nameof(Vector3IntObject))]
    public class Vector3IntObject : DynamicObject<Vector3Int>
    {
    }
}
