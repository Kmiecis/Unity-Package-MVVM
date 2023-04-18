using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(ColorAsset), fileName = nameof(ColorAsset))]
    public sealed class ColorAsset : ScriptableValue<Color>
    {
        public ColorAsset()
        {
            _value = Color.white;
        }
    }
}
