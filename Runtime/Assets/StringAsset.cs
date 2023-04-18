using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(StringAsset), fileName = nameof(StringAsset))]
    public sealed class StringAsset : ScriptableValue<string>
    {
        public StringAsset()
        {
            _value = string.Empty;
        }
    }
}
