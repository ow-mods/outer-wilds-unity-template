using UnityEngine;

public class WhiteHoleFluidVolume : FluidVolume
{
	[SerializeField]
	private float _outerRadius;
	[SerializeField]
	private float _innerRadius;
	[SerializeField]
	private AnimationCurve _densityCurve;
	[SerializeField]
	private float _flowSpeed;
	[SerializeField]
	private float _massiveFlowSpeed;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.matrix = Matrix4x4.TRS(base.transform.position, base.transform.rotation, Vector3.one);
			Gizmos.color = Color.blue;
			Gizmos.DrawWireSphere(Vector3.zero, _outerRadius);
			Gizmos.DrawWireSphere(Vector3.zero, _innerRadius);
		}
	}
}
