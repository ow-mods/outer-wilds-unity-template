using UnityEngine;

public class GalaxyMapController : MonoBehaviour
{
	[SerializeField]
	private Transform _playerWarpPoint;
	[SerializeField]
	private SingleInteractionVolume _interactVolume;
	[SerializeField]
	private Transform _eyeTransform;
	[SerializeField]
	private Transform _galaxyTransform;
	[SerializeField]
	private Transform _galaxyStartPos;
	[SerializeField]
	private Transform _galaxyEndPos;
	[SerializeField]
	private GameObject _forestObj;
	[SerializeField]
	private MiniGalaxyController _miniGalaxyController;
	[SerializeField]
	private OWTriggerVolume _observatoryVolume;
	[SerializeField]
	private OWAudioSource _audioSource;
	[SerializeField]
	private EndlessTriggerVolume _endlessObservatoryVolume;
	[SerializeField]
	private OWTriggerVolume _forestOfGalaxiesVolume;
	[Space]
	[SerializeField]
	private GameObject _supernovaPrefab;
	[SerializeField]
	private Shape _supernovaSpawnShape;
	[SerializeField]
	private float _supernovaSpawnRate = 10f;
	[SerializeField]
	private int _maxSupernovaCount = 100;
	[SerializeField]
	private float _supernovaSpeed = 200f;
	[Space]
	[SerializeField]
	private ParticleSystem[] _starParticles;
	[SerializeField]
	private float _starParticleDelay = 1f;
	[SerializeField]
	private float _exitGalaxyDelay = 4f;
}
