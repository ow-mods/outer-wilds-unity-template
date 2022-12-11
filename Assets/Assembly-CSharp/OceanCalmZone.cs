using UnityEngine;

[ExecuteInEditMode]
public class OceanCalmZone : MonoBehaviour
{
	[SerializeField]
	private OceanEffectController _ocean;
	[SerializeField]
	private float _radius = 10f;
	[SerializeField]
	[Range(0f, 1f)]
	private float _fadeFactor = 0.5f;
	[SerializeField]
	[Range(0f, 1f)]
	private float _strength = 0.25f;

	private void OnValidate()
	{
		if (_radius < 0f)
		{
			_radius = 0f;
		}
	}

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Gizmos.DrawWireSphere(Vector3.zero, _radius);
			Gizmos.DrawWireSphere(Vector3.zero, _radius * (1f - _fadeFactor));
		}
	}
}
