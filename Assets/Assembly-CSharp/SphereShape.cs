using UnityEngine;

[AddComponentMenu("Shapes/Sphere Shape", 1)]
public class SphereShape : Shape
{
	[SerializeField]
	protected Vector3 _center = Vector3.zero;
	[SerializeField]
	protected float _radius = 0.5f;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.green;
		float scale = 0f;
		Vector3 lossyScale = base.transform.lossyScale;
		for (int i = 0; i < 3; i++)
		{
			scale = Mathf.Max(scale, Mathf.Abs(lossyScale[i]));
		}
		Gizmos.DrawWireSphere(base.transform.position + _center, _radius * scale);
	}
}
