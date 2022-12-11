using UnityEngine;

public class MeshRendererBoundsOverride : MonoBehaviour
{
	[SerializeField]
	private Vector3 _boundsSize = Vector3.one;
	[SerializeField]
	private MeshFilter[] _meshFilters = new MeshFilter[0];
}
