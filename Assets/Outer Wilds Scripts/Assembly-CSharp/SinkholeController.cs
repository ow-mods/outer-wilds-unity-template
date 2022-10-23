using UnityEngine;

[RequireComponent(typeof(SinkholeFluidVolume))]
public class SinkholeController : MonoBehaviour
{
	[SerializeField]
	private bool _startActivated;
	[SerializeField]
	private MeshRenderer _sinkholeRenderer;
	[SerializeField]
	private int _sinkholeMaterialIndex;
	[Space(10f)]
	[SerializeField]
	private float _revealLength = 1f;
	[SerializeField]
	private Vector2 _uvScrollSpeed = new Vector2(0.1f, -0.1f);
	[Space(10f)]
	[SerializeField]
	private SandLevelController _sandSphere;
	[SerializeField]
	private float _sandsphereDeactivateHeight = -5f;

	private void OnDrawGizmosSelected()
	{
		OWRigidbody attachedOWRigidbody = GetComponent<OWRigidbody>() ?? GetComponentInParent<OWRigidbody>();
		Vector3 normalized = (((attachedOWRigidbody != null) ? attachedOWRigidbody.transform.position : Vector3.zero) - base.transform.position).normalized;
		Gizmos.color = Color.red;
		Gizmos.DrawRay(base.transform.position, normalized * (0f - _sandsphereDeactivateHeight));
		OWGizmos.DrawWireCircle(base.transform.position + normalized * (0f - _sandsphereDeactivateHeight), normalized, 1f);
	}
}
