using UnityEngine;

[RequireComponent(typeof(Camera))]
public class EyesImageEffect : MonoBehaviour
{
	[SerializeField]
	private Shader _eyesShader;
	[SerializeField]
	private Texture2D _eyesTexture;
	[SerializeField]
	[Range(0f, 1f)]
	private float _openness = 1f;
	[SerializeField]
	[Range(0.01f, 1f)]
	private float _blendWidth = 0.1f;
}
