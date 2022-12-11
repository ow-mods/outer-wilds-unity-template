using UnityEngine;

public class EyeTombController : MonoBehaviour
{
	[Header("Stage")]
	[SerializeField]
	private ObserveTrigger _graveObserveTrigger;
	[SerializeField]
	private GameObject _stageRoot;
	[SerializeField]
	private OWTriggerVolume _stageVolume;
	[SerializeField]
	private OWLightController _candleController;
	[Header("Interface")]
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private GearInterfaceEffects _gearEffects;
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private Transform _lockOnTransform;
	[Header("Projection")]
	[SerializeField]
	private OWLightController _planetLightController;
	[SerializeField]
	private OWRendererFadeController _lightBeamController;
	[SerializeField]
	private GameObject _planetObject;
	[SerializeField]
	private GameObject _stateRoot;
	[SerializeField]
	private GameObject[] _states;
	[Header("Signal")]
	[SerializeField]
	private AudioSignal _buriedSignal;
	[SerializeField]
	private Transform _signalDeepSocket;
	[Header("Instrument")]
	[SerializeField]
	private QuantumInstrument _instrument;
	[SerializeField]
	private GameObject _finalTombState;
	[SerializeField]
	private Transform _returnSocket;
}
