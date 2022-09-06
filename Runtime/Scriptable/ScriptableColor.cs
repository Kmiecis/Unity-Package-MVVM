using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(ScriptableColor), fileName = nameof(ScriptableColor))]
    public sealed class ScriptableColor : ScriptableValue<Color>
    {
        public ScriptableColor()
        {
            _value = Color.white;
        }
    }
}
