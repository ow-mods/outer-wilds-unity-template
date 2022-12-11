using UnityEngine;

public class DreamRaftController : MonoBehaviour
{
	[SerializeField]
	private float _turboSpeed = 10f;
	[SerializeField]
	private LightSensor _turboSensor;
	[SerializeField]
	private OWAudioSource _audioSource;
	[Space]
	[SerializeField]
	private DreamRiverFluidVolume _riverFluid;
	[SerializeField]
	private DreamRaftFluidDetector _fluidDetector;
	[Space]
	[SerializeField]
	private OWCollider[] _colliders = new OWCollider[0];
	[SerializeField]
	private Shape[] _shapes = new Shape[0];
}
