using UnityEngine;

[RequireComponent(typeof(OWRigidbody))]
public class QuantumOrbit : MonoBehaviour
{
	[SerializeField]
	private int _stateIndex = -1;
	[SerializeField]
	private float _orbitRadius;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = new ColorHSV(277f, 1f, 1f).ToColorRGB();
			Gizmos.DrawWireSphere(base.transform.position, _orbitRadius);
		}
	}
}
