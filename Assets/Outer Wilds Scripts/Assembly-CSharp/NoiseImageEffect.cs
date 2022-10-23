using UnityEngine;

[ExecuteInEditMode]
[ImageEffectAllowedInSceneView]
[RequireComponent(typeof(Camera))]
public class NoiseImageEffect : MonoBehaviour
{
	[SerializeField]
	private Shader _noiseShader;
	[SerializeField]
	private Vector2 _resolution = new Vector2(512f, 512f);
	[SerializeField]
	[Range(0f, 1f)]
	private float _strength = 0.1f;
}
