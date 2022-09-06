using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(ScriptableFloat), fileName = nameof(ScriptableFloat))]
    public sealed class ScriptableFloat : ScriptableValue<float>
    {
    }
}
