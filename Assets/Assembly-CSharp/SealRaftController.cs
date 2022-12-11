using UnityEngine;

public class SealRaftController : MonoBehaviour
{
	[SerializeField]
	private AbstractGhostDoorInterface _codeInterface;
	[Space]
	[SerializeField]
	private Transform _nearNode;
	[SerializeField]
	private Transform _farNode;
	[Space]
	[SerializeField]
	private LightSensor _nearSensor;
	[SerializeField]
	private LightSensor _farSensor;
	[Space]
	[SerializeField]
	private OWCollider[] _colliders = new OWCollider[0];
	[SerializeField]
	private Shape[] _shapes = new Shape[0];
	[SerializeField]
	private AlignToSurfaceFluidDetector _fluidDetector;
	[Header("Audio")]
	[SerializeField]
	private float _minSpeed = 1f;
	[SerializeField]
	private float _maxSpeed = 5f;
	[SerializeField]
	private OWAudioSource _audioSource;

	private void OnDrawGizmosSelected()
	{
		if (_nearNode != null)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawWireCube(_nearNode.position, new Vector3(6f, 1f, 6f));
		}
		if (_farNode != null)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawWireCube(_farNode.position, new Vector3(6f, 1f, 6f));
		}
		if (_nearSensor != null)
		{
			Gizmos.color = Color.white;
			Gizmos.DrawWireSphere(_nearSensor.transform.position, 30f);
		}
		if (_farSensor != null)
		{
			Gizmos.color = Color.white;
			Gizmos.DrawWireSphere(_farSensor.transform.position, 30f);
		}
	}
}
