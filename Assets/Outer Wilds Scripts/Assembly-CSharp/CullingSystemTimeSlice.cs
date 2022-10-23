using UnityEngine;

public class CullingSystemTimeSlice : MonoBehaviour
{
	[SerializeField]
	private GameObject _CullingRoot;
	[SerializeField]
	private GameObject _CullingCenter;
	[SerializeField]
	private float _InteriorRadius;
	public bool DEBUG;
	public int _FrameSlice;
	[SerializeField]
	[Range(-1f, 1f)]
	private float DOT;
	[SerializeField]
	private MeshRenderer[] _MeshRenderers;
	[SerializeField]
	private Transform[] _Transforms;
	[SerializeField]
	private Vector3[] _RenderCenters;

	private void OnDrawGizmosSelected()
	{
		if (_CullingCenter == null) return;
		Gizmos.color = new Color(1f, 1f, 0f, 0.75f);
		Gizmos.DrawSphere(_CullingCenter.transform.position, _InteriorRadius);
	}
}
