using UnityEngine;

public class DamFragmentController : MonoBehaviour
{
	[SerializeField]
	private Sector _sector;
	[Space]
	[SerializeField]
	private Transform _snapTarget;
	[SerializeField]
	private float _attachDelay = 20f;
	[SerializeField]
	private OWCollider[] _lowResColliders = new OWCollider[0];
	[SerializeField]
	private OWCollider _highResCollider;
	[SerializeField]
	private GameObject _turningOffInFlood;
}
