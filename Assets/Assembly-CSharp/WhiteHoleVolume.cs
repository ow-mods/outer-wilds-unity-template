using UnityEngine;

public class WhiteHoleVolume : MonoBehaviour
{
	[SerializeField]
	private Sector _whiteHoleSector;
	[SerializeField]
	private NomaiAirlock[] _airlocksToOpen;
	[Space]
	[SerializeField]
	private float _radius = 50f;
	[SerializeField]
	private float _debrisDistMin = 150f;
	[SerializeField]
	private float _debrisDistMax = 1000f;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.white;
		Gizmos.DrawWireSphere(base.transform.position, _radius);
		OWGizmos.DrawWireCircle(base.transform.position, Vector3.up, _debrisDistMin);
		OWGizmos.DrawBillboardedWireCircle(base.transform.position, _debrisDistMin);
		OWGizmos.DrawWireCircle(base.transform.position, Vector3.up, _debrisDistMax);
		OWGizmos.DrawBillboardedWireCircle(base.transform.position, _debrisDistMax);
		Gizmos.color = Color.red;
		Gizmos.DrawSphere(base.transform.position + base.transform.forward * _radius, 0.5f);
		Gizmos.DrawLine(base.transform.position, base.transform.position + base.transform.forward * 200f);
	}
}
