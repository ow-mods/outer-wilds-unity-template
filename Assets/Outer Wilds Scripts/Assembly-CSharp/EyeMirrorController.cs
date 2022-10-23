using UnityEngine;

public class EyeMirrorController : MonoBehaviour
{
	[Header("Hide In Tomb")]
	[SerializeField]
	private OWLight2 _planetFillLight;
	[Header("Portraits")]
	[SerializeField]
	private AbstractDoor _door;
	[SerializeField]
	private EyeTombPortrait[] _portraits;
	[Header("Volumes")]
	[SerializeField]
	private OWTriggerVolume _tombVolume;
	[SerializeField]
	private OWTriggerVolume _probeDestructionVolume;
	[SerializeField]
	private EndlessCylinder _forestCylinder;
	[SerializeField]
	private OWTriggerVolume _closeDoorTrigger;
	[Header("Signals")]
	[SerializeField]
	private AudioSignal _buriedSignal;
	[SerializeField]
	private AudioSignal _instrumentSignal;
	[Header("Mirror")]
	[SerializeField]
	private DreamCandle _dreamCandle;
	[SerializeField]
	private OWFlameController _mirrorCandle;
	[SerializeField]
	private GameObject _mirrorPlayer;
	[SerializeField]
	private VisibilityObject _mirrorVisibilityObject;
	[SerializeField]
	private GameObject _mirrorProbe;
	[SerializeField]
	private Transform _mirrorProbeScaleRoot;
	[SerializeField]
	private Transform _mirrorProbeCenterBone;
	[Header("Mummy")]
	[SerializeField]
	private GameObject _mummyObject;
	[SerializeField]
	private GameObject _tunnelBlocker;
	[Header("Instrument")]
	[SerializeField]
	private VisibilityObject _instrumentVisibilityObject;
	[SerializeField]
	private OWRigidbody _instrumentBody;
	[SerializeField]
	private OWAudioSource _instrumentImpactAudio;
}
