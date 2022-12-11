using UnityEngine;

public class SandFunnelController : MonoBehaviour
{
	[SerializeField]
	private float _growAfterMinutes = 1f;
	[SerializeField]
	private float _shrinkAfterMinutes = 16f;
	[Space]
	[SerializeField]
	private Transform _scaleRoot;
	[SerializeField]
	private SandLevelController _caveTwinSandLevel;
	[SerializeField]
	private SandLevelController _towerTwinSandLevel;
	[SerializeField]
	private GameObject[] _sandGeoObjects;
	[SerializeField]
	private Transform _caveTwinEffectsRoot;
	[SerializeField]
	private Transform _towerTwinEffectsRoot;
	[SerializeField]
	private OWAudioSource[] _audioSources;
	[Space]
	[SerializeField]
	private OWTriggerVolume _lakebedCaveVolume;
	[SerializeField]
	private OWRenderer[] _sandRenderers;
	[SerializeField]
	private Transform _hgtTowerTransform;
	[SerializeField]
	private Sector _particleCullSector;
}
