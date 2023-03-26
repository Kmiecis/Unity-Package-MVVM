using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(Vector3Asset), fileName = nameof(Vector3Asset))]
    public sealed class Vector3Asset : ScriptableValue<Vector3>
    {
    }
}
