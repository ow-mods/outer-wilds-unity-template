using UnityEngine;

public class CullingSystemTest : MonoBehaviour
{
	public bool DEBUG;
	[SerializeField]
	private GameObject planetCenter;
	[SerializeField]
	[Range(-1f, 1f)]
	private float DOT;
	[SerializeField]
	private MeshRenderer[] _MeshRenderers;
	[SerializeField]
	private Transform[] _Transforms;
	[SerializeField]
	private Vector3[] _RenderCenters;
}
