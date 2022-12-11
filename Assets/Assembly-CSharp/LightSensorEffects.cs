using UnityEngine;

[RequireComponent(typeof(LightSensor))]
public class LightSensorEffects : MonoBehaviour
{
	[SerializeField]
	private Material _glowMaterial;
	[SerializeField]
	private MeshRenderer _renderer;
	[SerializeField]
	private bool _useNewLensEffect = true;
	[SerializeField]
	private float _fadeInLength = 0.0625f;
	[SerializeField]
	private float _fadeOutLength = 0.125f;
	[SerializeField]
	private AudioLoopCrossfader _audioLoopCrossfader;
}
