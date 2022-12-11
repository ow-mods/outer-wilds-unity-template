using System;
using UnityEngine;

[RequireComponent(typeof(MeshCollider))]
public class FragmentCollisionProxy : MonoBehaviour
{
	[Serializable]
	public struct MeteorData
	{
		public MeteorController meteor;
		public Vector3 prevLocalPosition;
	}

	[Serializable]
	public struct MeteorImpact
	{
		public MeteorController meteor;
		public GameObject impactedObject;
		public Vector3 impactPosition;
		public Vector3 impactVelocity;
	}

	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private float _boundsRadius = 500f;
	[Space]
	[Space]
	private Transform _testRaycaster;
	[SerializeField]
	private float _testRaycastLength;
	[SerializeField]
	[HideInInspector]
	private Mesh _proxyColliderMesh;
	[SerializeField]
	[HideInInspector]
	private FragmentIntegrity[] _fragmentArray;
	[SerializeField]
	[HideInInspector]
	private int[] _submeshIndices;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = Color.red;
			Gizmos.DrawWireSphere(base.transform.position, _boundsRadius);
		}
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		if (_testRaycaster != null) Gizmos.DrawLine(_testRaycaster.position, _testRaycaster.position + _testRaycaster.forward * _testRaycastLength);
	}
}
