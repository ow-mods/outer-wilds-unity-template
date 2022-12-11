using UnityEngine;

public class AnglerfishFluidVolume : FluidVolume
{
	[SerializeField]
	private Vector3 _attractionPoint = Vector3.zero;
	[SerializeField]
	private float _attractionRadius = 1f;
	[SerializeField]
	private float _flowSpeed = 1f;

	protected void OnDrawGizmosSelected()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix * Matrix4x4.Scale(base.transform.lossyScale).inverse;
		Gizmos.color = new Color(1f, 0.5f, 0f);
		Gizmos.DrawWireSphere(_attractionPoint, _attractionRadius);
	}
}
