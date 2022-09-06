using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(ScriptableVector3), fileName = nameof(ScriptableVector3))]
    public sealed class ScriptableVector3 : ScriptableValue<Vector3>
    {
    }
}
