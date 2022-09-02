using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(ColorObject), fileName = nameof(ColorObject))]
    public class ColorObject : DynamicObject<Color>
    {
    }
}
