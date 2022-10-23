using UnityEngine;

public class SinkholeFluidVolume : FluidVolume
{
	[SerializeField]
	private Vector3 _vortexCenter = Vector3.zero;
	[SerializeField]
	private Vector3 _vortexDirection = Vector3.down;
	[SerializeField]
	private float _vortexSuctionRadius = 1f;
	[Space(10f)]
	[SerializeField]
	private float _downwardFlowSpeed = 0.5f;
	[SerializeField]
	private float _inwardFlowSpeed = 1.5f;

	protected void OnDrawGizmosSelected()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix * Matrix4x4.Scale(base.transform.lossyScale).inverse;
		Gizmos.color = new Color(1f, 0.5f, 0f);
		Gizmos.DrawWireSphere(_vortexCenter, _vortexSuctionRadius);
		Gizmos.DrawRay(_vortexCenter, _vortexDirection * _vortexSuctionRadius * 2f);
	}
}
