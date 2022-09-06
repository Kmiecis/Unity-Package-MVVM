using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(ScriptableString), fileName = nameof(ScriptableString))]
    public sealed class ScriptableString : ScriptableValue<string>
    {
    }
}
