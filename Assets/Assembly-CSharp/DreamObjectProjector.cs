using UnityEngine;

public class DreamObjectProjector : MonoBehaviour
{
	[SerializeField]
	protected bool _startLit;
	[SerializeField]
	protected bool _extinguishOnly;
	[SerializeField]
	protected DreamObjectProjection[] _projections = new DreamObjectProjection[0];
	[SerializeField]
	protected DreamObjectProjector[] _extinguishedProjectors = new DreamObjectProjector[0];
	[SerializeField]
	protected AudioVolume[] _lightsOutAudioVolumes = new AudioVolume[0];
	[SerializeField]
	protected DreamCandle[] _dreamCandles = new DreamCandle[0];
	[Space]
	[SerializeField]
	protected LightSensor _lightSensor;
	[SerializeField]
	protected InteractReceiver _interactReceiver;
	[SerializeField]
	protected OWTriggerVolume _triggerVolume;
	[SerializeField]
	protected OWFlameController _flameController;
	[SerializeField]
	protected AlarmTotem _alarmTotem;
	[Space]
	[Header("Audio Sources")]
	[SerializeField]
	private OWAudioSource _farOneShotSource;
	[SerializeField]
	private OWAudioSource _closeOneShotSource;
}
