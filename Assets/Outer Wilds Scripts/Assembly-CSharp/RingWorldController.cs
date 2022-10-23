using UnityEngine;

public class RingWorldController : MonoBehaviour
{
	[SerializeField]
	private OWRigidbody _ringWorldBody;
	[SerializeField]
	private OWRigidbody _staticRingBody;
	[SerializeField]
	private OWTriggerVolume[] _enterOnWakeVolumes;
	[SerializeField]
	private OWTriggerVolume _insideRingWorldVolume;
	[SerializeField]
	private RingRiverController _riverController;
	[SerializeField]
	private RingRiverPathAudioController _riverPathAudioController;
	[Header("Timers")]
	[SerializeField]
	private float _sailDeployTime = 400f;
	[SerializeField]
	private float _lightFlickerTime = 401f;
	[SerializeField]
	private float _departTime = 405f;
	[SerializeField]
	private float _damDamageTime = 410f;
	[SerializeField]
	private float _damBreakTime = 780f;
	[SerializeField]
	private float _lighthouseCollapseTime = 1220f;
	[Header("Solar Sail")]
	[SerializeField]
	private Animation[] _solarSailAnimations;
	[SerializeField]
	private OWCollider _solarSailClosedCollider;
	[SerializeField]
	private OWCollider _solarSailOpenCollider;
	[SerializeField]
	private GameObject _solarSailClosedProxy;
	[SerializeField]
	private GameObject _solarSailOpenProxy;
	[SerializeField]
	private float _sailDeployDuration = 12f;
	[SerializeField]
	private Vector3 _departDirection = Vector3.up;
	[SerializeField]
	private float _departAcceleration = 10f;
	[SerializeField]
	private float _interiorAccelFactor;
	[Header("Dam")]
	[SerializeField]
	private RingWorldFlickerController _flickerController;
	[SerializeField]
	private RingWorldScreenController _screenController;
	[SerializeField]
	private DamDestructionController _damController;
	[SerializeField]
	private LighthouseController _lighthouseController;
	[SerializeField]
	private OWTriggerVolume _zone1TriggerVolume;
	[SerializeField]
	private float _damLifeExtendDuration = 60f;
	[Header("AudioSources")]
	[SerializeField]
	private OWAudioSource _solarSailOneShot;
	[SerializeField]
	private OWAudioSource _solarSailLooping;
	[SerializeField]
	private OWAudioSource _flickerOneShot;
	[SerializeField]
	private OWAudioSource _damOneShotAudio_Far;
}
