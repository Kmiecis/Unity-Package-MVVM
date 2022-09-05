using Common.MVB;
using UnityEditor;

namespace CommonEditor.MVB
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(DynamicObject<>), true)]
    public class DynamicObjectEditor : Editor
    {
        private SerializedProperty _valueProperty;

        private void OnEnable()
        {
            _valueProperty = serializedObject.FindProperty("_value");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.PropertyField(_valueProperty);

            if (
                serializedObject.ApplyModifiedProperties() &&
                target is IInvokeable invokeable
            )
            {
                invokeable.Invoke();
            }
        }
    }
}
