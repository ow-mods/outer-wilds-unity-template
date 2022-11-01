using UnityEditor;
using UnityEngine;

namespace OW
{
	[CanEditMultipleObjects]
	[CustomEditor(typeof (Light))]
	public class AmbientLightEditor : LightEditor
	{
		SerializedProperty _color;
		SerializedProperty _intensity;
		SerializedProperty _range;
		SerializedProperty _shadowType;
		SerializedProperty _cookie;

		protected override void OnEnable()
		{
			base.OnEnable();
			
			// Get serialized properties from light component
			_color = serializedObject.FindProperty("m_Color");
			_intensity = serializedObject.FindProperty("m_Intensity");
			_range = serializedObject.FindProperty("m_Range");
			_shadowType = serializedObject.FindProperty("m_LightShadowCasterMode");
			_cookie = serializedObject.FindProperty("m_Cookie");
		}

		/// Override the OnGui method to draw the custom inspector controls
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();
			
			// If there is a cubemap in the cookie slot, and the light type is point run DrawAmbientControls();
			if (_cookie.objectReferenceValue != null && ((Light)target).type == LightType.Point)
			{
				serializedObject.Update();
				DrawAmbientControls();
				// Hide all properties that are not needed for the ambient light from the default light editor
				serializedObject.ApplyModifiedProperties();
			}
		}

		private void DrawAmbientControls()
		{
			Color newColor = _color.colorValue;
			
			// Space & "Ambient light controls" header
			EditorGUILayout.Space();
			EditorGUILayout.LabelField( "Ambient light controls", EditorStyles.boldLabel );

			EditorGUILayout.PropertyField(_range, new GUIContent("Outer Radius", "Distance at which ambient light has fallen off completely."));
			float innerRadius = Mathf.Pow(newColor.r, 2.0f) * _range.floatValue; // Compensating for squared lighting falloff in the shader
			innerRadius = EditorGUILayout.Slider(new GUIContent("Inner Radius", "Distance at which ambient light falloff starts."), innerRadius, 0.0f, _range.floatValue);
			newColor.r = Mathf.Sqrt(innerRadius / _range.floatValue);
			newColor.r = float.IsNaN(newColor.r) ? 0.0f : newColor.r;
			newColor.g = EditorGUILayout.Toggle( new GUIContent("Shell", "If set, ambient will work as a shell from Inner Raudious to Outer Radius."), newColor.g > 0.0f) ? 1.0f : 0.0f;
			newColor.b = 1.0f;
		
			EditorGUILayout.Space();
			EditorGUILayout.Slider(_intensity, 0.0f, 3.0f, GetGUIContent(_intensity));
			// Sqrt the fall going in to the slider and square it coming out to allow for better slider control
			newColor.a = Mathf.Pow(EditorGUILayout.Slider(new GUIContent("Falloff", "Ambient Light falloff exponent."), Mathf.Sqrt(newColor.a), 0.0707f, 1.0f), 2.0f);
			_color.colorValue = newColor;
			EditorGUILayout.PropertyField(_cookie, new GUIContent("Ambient Light Cubemap", "Cubemap used for ambient lighting lookup."));
			// CHECK UNITY TALK FOR REFERENCE !

			_shadowType.intValue = (int)LightShadows.None;
		}

		private GUIContent GetGUIContent( SerializedProperty serializedProperty )
		{
			return new GUIContent( serializedProperty.displayName, serializedProperty.tooltip );
		}
	}
}
