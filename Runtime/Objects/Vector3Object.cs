using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(Vector3Object), fileName = nameof(Vector3Object))]
    public class Vector3Object : DynamicObject<Vector3>
    {
    }
}
