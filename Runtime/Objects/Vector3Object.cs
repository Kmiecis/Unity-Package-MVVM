using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(Vector3Object), fileName = nameof(Vector3Object))]
    public sealed class Vector3Object : ScriptableValue<Vector3>
    {
    }
}
