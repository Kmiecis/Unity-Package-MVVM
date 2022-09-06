using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(ScriptableInt), fileName = nameof(ScriptableInt))]
    public sealed class ScriptableInt : ScriptableValue<int>
    {
    }
}
