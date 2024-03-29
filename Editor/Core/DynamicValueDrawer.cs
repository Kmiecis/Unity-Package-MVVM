using Common.MVVM;
using UnityEditor;
using UnityEngine;

namespace CommonEditor.MVVM
{
    [CustomPropertyDrawer(typeof(DynamicValue<>))]
    public class DynamicValueDrawer : PropertyDrawer
    {
        private object GetValue(SerializedProperty property)
        {
            return fieldInfo.GetValue(property.serializedObject.targetObject);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.PropertyField(position, property, label, true);

            if (
                property.serializedObject.ApplyModifiedProperties() &&
                GetValue(property) is IInvokeable invokeable
            )
            {
                invokeable.Invoke();
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }
    }
}
