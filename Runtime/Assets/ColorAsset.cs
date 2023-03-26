using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(ColorAsset), fileName = nameof(ColorAsset))]
    public sealed class ColorAsset : ScriptableValue<Color>
    {
        public ColorAsset()
        {
            _value = Color.white;
        }
    }
}
