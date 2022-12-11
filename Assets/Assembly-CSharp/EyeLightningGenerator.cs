using UnityEngine;

public class EyeLightningGenerator : CloudLightningGenerator
{
	[Space]
	[SerializeField]
	protected float _radius = 100f;
	[SerializeField]
	protected Range _branchAngle = new Range(-45f, 45f);

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.matrix = base.transform.localToWorldMatrix;
		OWGizmos.DrawWireCircle(Vector3.zero, Vector3.up, _radius);
	}
}
