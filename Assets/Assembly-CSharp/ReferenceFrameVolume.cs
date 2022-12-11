using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class ReferenceFrameVolume : MonoBehaviour
{
	[SerializeField]
	protected ReferenceFrame _referenceFrame;
	[Space(10f)]
	[SerializeField]
	protected float _minColliderRadius = 5f;
	[SerializeField]
	protected float _maxColliderRadius = 10f;
	[Space(10f)]
	[SerializeField]
	protected bool _isPrimaryVolume = true;
	[SerializeField]
	protected bool _isCloseRangeVolume = true;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = new Color(1f, 0f, 0f, 0.5f);
			OWGizmos.DrawBillboardedWireCircle(base.transform.position, _referenceFrame.GetMinSuitTargetDistance());
			OWGizmos.DrawBillboardedWireCircle(base.transform.position, _referenceFrame.GetMaxTargetDistance());
			Gizmos.color = new Color(0.25f, 0.25f, 1f, 1f);
			OWGizmos.DrawBillboardedWireCircle(base.transform.position, _referenceFrame.GetAutopilotArrivalDistance());
			Gizmos.color = new Color(1f, 1f, 0f, 0.5f);
			OWGizmos.DrawBillboardedWireCircle(base.transform.position, _referenceFrame.GetAutoAlignmentDistance());
			Gizmos.color = new Color(1f, 0f, 1f, 0.5f);
			Gizmos.DrawWireSphere(base.transform.position, _referenceFrame.GetMinMatchAngularVelocityDistance());
			Gizmos.DrawWireSphere(base.transform.position, _referenceFrame.GetMaxMatchAngularVelocityDistance());
			Gizmos.color = new Color(1f, 1f, 1f, 1f);
			OWGizmos.DrawBillboardedWireCircle(base.transform.position, _referenceFrame.GetBracketsRadius());
			SphereCollider component = GetComponent<SphereCollider>();
			if (component == null) return;
			float value = Vector3.Distance(Camera.current.transform.position, base.transform.position);
			float radius = Mathf.Lerp(_minColliderRadius, _maxColliderRadius, Mathf.InverseLerp(_minColliderRadius * 2f, _maxColliderRadius * 2f, value));
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Gizmos.color = new Color(0.5f, 1f, 0.5f, 0.25f);
			Gizmos.DrawWireSphere(component.center, _minColliderRadius);
			Gizmos.DrawWireSphere(component.center, _maxColliderRadius);
			Gizmos.color = new Color(0.5f, 1f, 0.5f, 1f);
			Gizmos.DrawWireSphere(component.center, radius);
		}
	}
}
