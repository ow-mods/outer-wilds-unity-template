using UnityEngine;

[RequireComponent(typeof(OWCamera))]
public class LandingCamera : MonoBehaviour
{
	[SerializeField]
	private float _aspectRatio = 1.33333337f;
	[SerializeField]
	private RenderTexture _targetTexture;
	[Space]
	[SerializeField]
	private Shader _landingCamShader;
	[SerializeField]
	private Texture2D _landingCameraLUT;
	[SerializeField]
	[Range(0f, 1f)]
	private float _landingCameraNoise = 0.005f;
}
