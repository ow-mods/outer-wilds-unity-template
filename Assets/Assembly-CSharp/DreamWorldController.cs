using UnityEngine;

public class DreamWorldController : MonoBehaviour
{
	[SerializeField]
	private DreamLanternItem _debugPlayerLantern;
	[Header("Simulation")]
	[SerializeField]
	private Transform _primarySimulationRoot;
	[SerializeField]
	private Transform[] _simulationRoots = new Transform[0];
	[SerializeField]
	private SimulationCamera _simulationCamera;
	[SerializeField]
	private OWRenderer _simulationSphere;
	[Space]
	[SerializeField]
	private Sector _dreamWorldSector;
	[SerializeField]
	private OWTriggerVolume _dreamWorldVolume;
	[SerializeField]
	private Color _tempSkyboxColor;
	[Space]
	[SerializeField]
	private SarcophagusController _sarcophagusController;
}
