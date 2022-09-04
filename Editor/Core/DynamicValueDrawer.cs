using Common.MVB;
using UnityEditor;
using UnityEngine;

namespace CommonEditor.MVB
{
    [CustomPropertyDrawer(typeof(DynamicValue<>))]
    public class DynamicValueDrawer : PropertyDrawer
    {
        private object GetTarget(SerializedProperty property)
        {
            return fieldInfo.GetValue(property.serializedObject.targetObject);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginChangeCheck();

            EditorGUI.PropertyField(position, property, label, true);

            if (EditorGUI.EndChangeCheck())
            {
                // Apply early, so we can Invoke with new values
                property.serializedObject.ApplyModifiedProperties();

                if (GetTarget(property) is IInvokeable invokeable)
                    invokeable.Invoke();
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }
    }
}
