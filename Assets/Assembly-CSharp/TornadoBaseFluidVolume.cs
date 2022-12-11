using UnityEngine;

public class TornadoBaseFluidVolume : FluidVolume
{
	[SerializeField]
	private float _flowSpeed;
	[SerializeField]
	private float _innerRadius;
	[SerializeField]
	private float _outerRadius;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		OWGizmos.DrawWireCircle(base.transform.position, base.transform.up, _innerRadius);
		OWGizmos.DrawWireCircle(base.transform.position, base.transform.up, _outerRadius);
	}
}
