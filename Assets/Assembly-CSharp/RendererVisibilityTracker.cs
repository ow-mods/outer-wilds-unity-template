using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class RendererVisibilityTracker : VisibilityTracker
{
	[SerializeField]
	private Collider[] _ignoreOcclusionColliders;
	[SerializeField]
	private bool _checkOcclusion;
	[SerializeField]
	private bool _checkFrustumOcclusion;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireCube(GetComponent<Renderer>().bounds.center, GetComponent<Renderer>().bounds.size);
	}
}
