using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(ColorObject), fileName = nameof(ColorObject))]
    public sealed class ColorObject : ScriptableValue<Color>
    {
        public ColorObject()
        {
            _value = Color.white;
        }
    }
}
