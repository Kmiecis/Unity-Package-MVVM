using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(ScriptableDouble), fileName = nameof(ScriptableDouble))]
    public sealed class ScriptableDouble : ScriptableValue<double>
    {
    }
}
