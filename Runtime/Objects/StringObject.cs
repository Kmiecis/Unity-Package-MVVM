using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(StringObject), fileName = nameof(StringObject))]
    public sealed class StringObject : ScriptableValue<string>
    {
    }
}
