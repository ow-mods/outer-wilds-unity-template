using UnityEngine;

public class NomaiVesselComputerRing : MonoBehaviour
{
	[SerializeField]
	private OWRenderer _ringRenderer;
	[SerializeField]
	private OWRenderer _projectorRenderer;
	[SerializeField]
	private float _radius = 0.5f;
	[SerializeField]
	private float _spinSpeedMin = 10f;
	[SerializeField]
	private float _spinSpeedMax = 30f;
	[SerializeField]
	private float _flickerLength = 1f;
	[SerializeField]
	private float _colorFadeTime = 1f;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = Color.red;
			OWGizmos.DrawWireCircle(base.transform.position, base.transform.up, _radius);
		}
	}
}
