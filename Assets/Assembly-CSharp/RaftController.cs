using UnityEngine;

public class RaftController : MonoBehaviour
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private RingRiverFluidVolume _riverFluid;
	[SerializeField]
	private bool _debug;
	[Space]
	[SerializeField]
	private float _acceleration = 5f;
	[SerializeField]
	private LightSensor[] _lightSensors;
	[Space]
	[SerializeField]
	private Shape _detectorShape;
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private RaftFluidDetector _fluidDetector;
	[SerializeField]
	private OWTriggerVolume _rideVolume;
	[SerializeField]
	private OWAudioSource _oneShotAudio;
	[Space]
	[SerializeField]
	private OWCollider[] _railingColliders = new OWCollider[0];
	[SerializeField]
	private Animator _railingAnimator;
	[SerializeField]
	private float _dropDelay;
}
