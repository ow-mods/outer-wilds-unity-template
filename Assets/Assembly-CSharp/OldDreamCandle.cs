using UnityEngine;

public class OldDreamCandle : MonoBehaviour
{
	[SerializeField]
	private bool _startLit = true;
	[Space]
	[SerializeField]
	private GameObject _objectsVisibleInLight;
	[SerializeField]
	private OWLightController[] _linkedLightControllers;
	[SerializeField]
	private GhostController[] _ghostsToWake;
	[SerializeField]
	private DarkZone _darkZone;
	[Space]
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private OWLightController _candleLightController;
	[SerializeField]
	private ParticleSystem _candleParticles;
	[SerializeField]
	private LensFlare _lensFlare;
	[SerializeField]
	private AudioVolume _audioVolume;
}
