using UnityEngine;

public class CageElevator : MonoBehaviour
{
	[Header("References")]
	[SerializeField]
	private OWRigidbody _platformBody;
	[Tooltip("Destination transforms, MUST be in order bottom - top")]
	[SerializeField]
	private ElevatorDestination[] _destinations;
	[SerializeField]
	private GameObject _elevatorFloorStandIn;
	[SerializeField]
	private OWTriggerVolume _killTriggerUpper;
	[SerializeField]
	private OWTriggerVolume _killTriggerLower;
	[SerializeField]
	private TransformAnimator _doorAnimatorLeft;
	[SerializeField]
	private TransformAnimator _doorAnimatorRight;
	[SerializeField]
	private AbstractGhostElevatorInterface _ghostInterface;
	[SerializeField]
	private Transform _chainsRoot;
	[SerializeField]
	private Transform _chainsEndPoint;
	[SerializeField]
	private float _initChainLength = 3f;
	[SerializeField]
	private OWCollider _leftDoorStandIn;
	[SerializeField]
	private OWCollider _rightDoorStandIn;
	[SerializeField]
	private OWCollider _bodyStandIn;
	[SerializeField]
	private OWLightController _topLight;
	[SerializeField]
	private OWRenderer _teleportChainsRenderer;
	[Header("Controls")]
	[SerializeField]
	private int _startDestination;
	[SerializeField]
	private bool _startOpen = true;
	[SerializeField]
	private bool _lightsStartOff;
	[SerializeField]
	private float _ascendAccel;
	[SerializeField]
	private float _ascendMaxSpeed;
	[SerializeField]
	private float _descendAccel;
	[SerializeField]
	private float _descendMaxSpeed;
	[Header("Audio")]
	[SerializeField]
	private OWAudioSource _oneShotAudio;
	[SerializeField]
	private OWAudioSource _loopingAudio;
	[SerializeField]
	private OWAudioSource _mechLoopingAudio;
}
