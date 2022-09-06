using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(ScriptableVector4), fileName = nameof(ScriptableVector4))]
    public sealed class ScriptableVector4 : ScriptableValue<Vector4>
    {
    }
}
