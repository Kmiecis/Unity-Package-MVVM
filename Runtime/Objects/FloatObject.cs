using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(FloatObject), fileName = nameof(FloatObject))]
    public class FloatObject : DynamicObject<float>
    {
    }
}
