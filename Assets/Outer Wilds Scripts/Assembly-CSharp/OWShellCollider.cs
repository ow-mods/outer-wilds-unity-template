using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class OWShellCollider : OWCustomCollider
{
	[SerializeField]
	private float _innerRadius = 0.25f;

	private void OnDrawGizmosSelected()
	{
		SphereCollider component = GetComponent<SphereCollider>();
		Gizmos.color = new Color(0.5f, 1f, 0.5f, component.enabled ? 0.33f : 0.1f);
		float num = Mathf.Max(Mathf.Max(base.transform.lossyScale.x, base.transform.lossyScale.y), base.transform.lossyScale.z);
		Gizmos.matrix = Matrix4x4.TRS(base.transform.position, base.transform.rotation, Vector3.one * num);
		Gizmos.DrawWireSphere(component.center, _innerRadius);
	}
}
