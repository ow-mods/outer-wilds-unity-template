using UnityEngine;

public class NeckSnapGhostController : MonoBehaviour
{
	[SerializeField]
	private Transform _solidHead;
	[SerializeField]
	private GameObject _solidRoot;
	[SerializeField]
	private GameObject _transparentRoot;
	[SerializeField]
	private OWLight _faceLight;
	[SerializeField]
	private float _wanderRadius;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.yellow;
		OWGizmos.DrawWireCircle(base.transform.position, base.transform.up, _wanderRadius);
	}
}
