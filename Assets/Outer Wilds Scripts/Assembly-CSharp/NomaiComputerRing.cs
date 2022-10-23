using UnityEngine;

public class NomaiComputerRing : MonoBehaviour
{
	[SerializeField]
	private float _radius = 0.5f;
	[SerializeField]
	private DampedSpring _translationSpring;
	[SerializeField]
	private DampedSpring _rotationSpring;
	[SerializeField]
	private float _idleSpinMinDegrees = 15f;
	[SerializeField]
	private float _idleSpinMaxDegrees = 270f;
	[SerializeField]
	private float _activeSpinSpeed = 30f;
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
