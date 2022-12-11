using UnityEngine;

public class VisorEffectController : MonoBehaviour
{
	[SerializeField]
	private OWCamera _owCamera;
	[SerializeField]
	private VisorEffectDetector _visorEffectDetector;
	[SerializeField]
	private Renderer _visorEffectRenderer;
	[Space]
	[SerializeField]
	private ParticleSystem _rainDropletsParticleSystem;
	[SerializeField]
	private ParticleSystem _rainStreaksParticleSystem;
	[Space]
	[SerializeField]
	private float _dirtClearLength = 1f;
	[SerializeField]
	private float _equilibriumDirt = 50f;
	[SerializeField]
	private float _maxDirt = 100f;
	[SerializeField]
	private float _dirtDecayRate = 10f;
	[Space]
	[SerializeField]
	private float _waterFadeInLength = 0.25f;
	[SerializeField]
	private float _waterClearLength = 1f;
	[SerializeField]
	private float _waterOffsetStart = -0.5f;
	[SerializeField]
	private float _waterOffsetEnd = 1f;
	[SerializeField]
	private int _waterNumDroplets = 16;
	[SerializeField]
	private float _waterNumStreaks = 8f;
	[Space]
	[SerializeField]
	private float _frostThawRate = 0.1f;
	[SerializeField]
	private float _defrostRate = 1f;
	[Space]
	[SerializeField]
	private PlayerCameraFluidDetector _cameraFluidDetector;
	[SerializeField]
	private AnimationCurve _breathFogCurve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);
	[SerializeField]
	private float _breathFogRandomness = 0.1f;
	[SerializeField]
	private float _breathFogFadeInLength = 30f;
	[SerializeField]
	private float _breathFogFadeOutLength = 1f;
	[Space]
	[SerializeField]
	private Renderer _crackEffectRenderer;
	[SerializeField]
	private AnimationCurve _impactCrackAnimCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
	[SerializeField]
	private AnimationCurve _crushedCrackAnimCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
}
