using UnityEngine;

public class MeteorLauncher : MonoBehaviour
{
	[SerializeField]
	private GameObject _meteorPrefab;
	[SerializeField]
	private GameObject _dynamicMeteorPrefab;
	[SerializeField]
	private float _dynamicProbability = 0.05f;
	[SerializeField]
	private float _minLaunchSpeed = 50f;
	[SerializeField]
	private float _maxLaunchSpeed = 150f;
	[SerializeField]
	private float _minInterval = 5f;
	[SerializeField]
	private float _maxInterval = 20f;
	[SerializeField]
	private Vector3 _launchDirection = Vector3.up;
	[SerializeField]
	private ParticleSystem[] _launchParticles = new ParticleSystem[0];
	[Header("Audio")]
	[SerializeField]
	private Sector _audioSector;
	[SerializeField]
	private OWAudioSource _launchSource;
	[Space]
	[SerializeField]
	private ForceVolume _detectableField;
	[SerializeField]
	private FluidVolume _detectableFluid;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawRay(base.transform.position, base.transform.TransformDirection(_launchDirection).normalized * (_minLaunchSpeed + _maxLaunchSpeed) * 0.5f);
		Gizmos.DrawWireSphere(base.transform.position, 10f);
	}
}
