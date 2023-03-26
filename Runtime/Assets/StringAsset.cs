using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(StringAsset), fileName = nameof(StringAsset))]
    public sealed class StringAsset : ScriptableValue<string>
    {
        public StringAsset()
        {
            _value = string.Empty;
        }
    }
}
