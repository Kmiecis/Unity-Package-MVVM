using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(ColorObject), fileName = nameof(ColorObject))]
    public class ColorObject : DynamicObject<Color>
    {
    }
}
