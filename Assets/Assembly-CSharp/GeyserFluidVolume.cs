using UnityEngine;

[RequireComponent(typeof(CapsuleShape))]
public class GeyserFluidVolume : FluidVolume
{
	[SerializeField]
	private float _directionalFlowSpeed;
	[SerializeField]
	private float _attractionalFlowSpeed;
	[SerializeField]
	private float _climbSpeed = 10f;
	[SerializeField]
	private float _attractionalRadiusFallOff = 0.5f;

	protected void OnDrawGizmosSelected()
	{
		var shape = GetComponent<CapsuleShape>();
		Matrix4x4 matrix4x = Matrix4x4.TRS(base.transform.position, base.transform.rotation, base.transform.lossyScale);
		Vector3 vector = Vector3.zero;
		if (shape.direction == 0) vector = Vector3.right * shape.height * 0.5f;
		else if (shape.direction == 1) vector = Vector3.up * shape.height * 0.5f;
		else if (shape.direction == 2) vector = Vector3.forward * shape.height * 0.5f;
		var capsuleStart = matrix4x.MultiplyPoint3x4(shape.center - vector);
		var capsuleEnd = matrix4x.MultiplyPoint3x4(shape.center + vector);
		Gizmos.color = Color.red;
		Gizmos.DrawRay(capsuleStart, Vector3.Normalize(capsuleEnd - capsuleStart) * shape.height);
	}
}
