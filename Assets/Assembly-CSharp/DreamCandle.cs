using UnityEngine;

public class DreamCandle : MonoBehaviour
{
	[SerializeField]
	private bool _startLit;
	[Space]
	[SerializeField]
	private OWLightController _lightController;
	[SerializeField]
	private LightSensor _lightSensor;
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[Header("Audio")]
	[SerializeField]
	private OWAudioSource _audioSource;
	[SerializeField]
	private AudioType _lightClip = AudioType.Candle_Light_Small;
}
