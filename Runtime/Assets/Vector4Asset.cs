using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(Vector4Asset), fileName = nameof(Vector4Asset))]
    public sealed class Vector4Asset : ScriptableValue<Vector4>
    {
    }
}
