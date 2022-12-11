using UnityEngine;

[RequireComponent(typeof(CapsuleShape))]
public class SandfallFluidVolume : FluidVolume
{
	[SerializeField]
	private float _verticalSpeed;
	[SerializeField]
	private float _inwardSpeed;
	[SerializeField]
	private float _falloffLength = 2f;

	private void OnDrawGizmosSelected()
	{
		var capsule = GetComponent<CapsuleShape>();
		Vector3 vector = base.transform.TransformPoint(new Vector3(0f, 0f - capsule.height, 0f));
		Gizmos.color = Color.red;
		Gizmos.DrawLine(vector, vector + base.transform.up * _falloffLength);
	}
}
