using UnityEngine;

public class RiverHazardToggle : SectoredMonoBehaviour
{
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
	[SerializeField]
	private bool _activePostFlood = true;
	[Space]
	[SerializeField]
	private OWTriggerVolume[] _triggerVolumes = new OWTriggerVolume[0];
	[SerializeField]
	private OWAudioSource[] _audioSources = new OWAudioSource[0];
	[SerializeField]
	private ParticleSystem[] _particles = new ParticleSystem[0];
	[SerializeField]
	private GameObject[] _gameObjects = new GameObject[0];
	[Space]
	[SerializeField]
	private PowerCableAudioController _powerCableAudio;
	[Header("Temp")]
	[SerializeField]
	private Sector _particleSectorOverride;
}
