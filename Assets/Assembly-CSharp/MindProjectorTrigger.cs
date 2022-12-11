using UnityEngine;

public class MindProjectorTrigger : SectoredMonoBehaviour
{
	[Space]
	[SerializeField]
	private bool _startActive;
	[SerializeField]
	private bool _deactivateOnCompletion;
	[SerializeField]
	private Transform _lockOnTransform;
	[Space]
	[SerializeField]
	private OWTriggerVolume _triggerVolume;
	[SerializeField]
	private MindSlideProjector _mindProjector;
	[Header("Custom Fade-In Curve")]
	[SerializeField]
	private bool _useCurve;
	[SerializeField]
	private AnimationCurve _intensityCurve;
	[Header("Projection Beam Effects")]
	[SerializeField]
	private OWRendererFadeController _lightRayFadeController;
	[SerializeField]
	private OWLightController _lightController;
	[SerializeField]
	private OWFlameController _flameController;
	[SerializeField]
	private ParticleSystem[] _particles;
	[Header("Scan Beam Effects (Optional")]
	[SerializeField]
	private Transform _scanBeamTransform;
	[SerializeField]
	private OWRendererFadeController _scanBeamFadeController;
	[SerializeField]
	private OWLightController _scanLightController;
	[SerializeField]
	private OWAudioSource _scanSource;
	[Header("Audio")]
	[SerializeField]
	private OWAudioSource _audioSource;
	[SerializeField]
	private OWAudioSource _loopingSource;
}
