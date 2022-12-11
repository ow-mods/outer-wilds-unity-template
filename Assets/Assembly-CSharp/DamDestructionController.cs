using UnityEngine;

public class DamDestructionController : MonoBehaviour
{
	[SerializeField]
	private RingWorldController _ringworldController;
	[SerializeField]
	private Sector _interiorSector;
	[SerializeField]
	private float _startIntegrity = 100f;
	[SerializeField]
	private float _damagedIntegrity = 84f;
	[Space]
	[SerializeField]
	private OWRenderer _leakRenderer;
	[SerializeField]
	private AnimationCurve _leakProgressionCurve;
	[SerializeField]
	private float _leakFadeOutLength = 1f;
	[Space]
	[SerializeField]
	private GameObject _intactDamRoot;
	[SerializeField]
	private GameObject _destroyedDamRoot;
	[SerializeField]
	private Collider _destroyedDamAnchorCollider;
	[SerializeField]
	private DamFragmentController[] _damFragments = new DamFragmentController[0];
	[SerializeField]
	private OWRigidbody[] _centerFragments = new OWRigidbody[0];
	[SerializeField]
	private OWRigidbody[] _topFragments = new OWRigidbody[0];
	[SerializeField]
	private Transform _destructionForceCenter;
	[SerializeField]
	private float _destructionForceRadius = 50f;
	[SerializeField]
	private float _destructionForceLinearAccel = 10f;
	[SerializeField]
	private float _destructionForceAngularAccel = 1f;
	[SerializeField]
	private float _destructionForceDuration = 1f;
	[SerializeField]
	private float _topFragmentsDelay = 1f;
	[Space]
	[SerializeField]
	private ParticleSystem[] _destructionParticles = new ParticleSystem[0];
	[Space]
	[SerializeField]
	private Vector3 _probeEjectLocalDir = new Vector3(0f, 0f, 1f);
	[SerializeField]
	private float _probeEjectSpeed = 10f;

	private void OnDrawGizmosSelected()
	{
		if (!OWGizmos.IsDirectlySelected(base.gameObject) || _destructionForceCenter == null) return;

		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(_destructionForceCenter.position, _destructionForceRadius);

		if (_centerFragments == null) return;
		
		foreach (var centerFragment in _centerFragments)
		{
			if (centerFragment != null)
			{
				Gizmos.DrawLine(_destructionForceCenter.position, centerFragment.transform.position);
			}
		}
	}
}
