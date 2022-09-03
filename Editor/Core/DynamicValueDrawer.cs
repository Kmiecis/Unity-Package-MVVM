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
            EditorGUI.BeginProperty(position, label, property);

            EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
            position.y += EditorGUI.GetPropertyHeight(property);

            int defaultIndentLevel = EditorGUI.indentLevel;

            EditorGUI.BeginChangeCheck();
            foreach (SerializedProperty child in property)
            {
                position.height = EditorGUI.GetPropertyHeight(child);

                var next = child.Copy();
                var hasNext = next.Next(true);

                EditorGUI.indentLevel = child.depth;
                if (hasNext && next.depth > child.depth)
                    EditorGUI.LabelField(position, child.displayName);
                else
                    EditorGUI.PropertyField(position, child, new GUIContent(child.displayName));

                position.y += position.height;
            }
            if (EditorGUI.EndChangeCheck())
            {
                // Apply, so we can Invoke with new values
                property.serializedObject.ApplyModifiedProperties();

                if (GetTarget(property) is IInvokeable invokeable)
                    invokeable.Invoke();
            }

            EditorGUI.indentLevel = defaultIndentLevel;

            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            property = property.Copy();

            var result = EditorGUI.GetPropertyHeight(property);
            foreach (SerializedProperty child in property)
            {
                result += EditorGUI.GetPropertyHeight(child);
            }
            return result;
        }
    }
}
