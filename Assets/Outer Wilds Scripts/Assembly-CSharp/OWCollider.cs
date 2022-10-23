using UnityEngine;

public class OWCollider : MonoBehaviour
{
	[SerializeField]
	private DynamicOccupantMask _lodActivationMask;
	[SerializeField]
	private bool _ignorePhysicsSwapDelay;
	[SerializeField]
	private bool _drawBounds;
	[Header("Streaming")]
	[SerializeField]
	private bool _doNotStream;

	private void OnDrawGizmos()
	{
		if (_drawBounds)
		{
			Gizmos.color = Color.white;
			Gizmos.DrawWireCube(GetComponent<Collider>().bounds.center, GetComponent<Collider>().bounds.size);
		}
	}
}
