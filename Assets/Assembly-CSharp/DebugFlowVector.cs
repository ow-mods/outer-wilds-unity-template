using UnityEngine;

public struct DebugFlowVector
{
	public Vector3 localPosition;

	public Vector3 localVelocity;

	public void Draw(Transform parent, float velocityScale)
	{
		Matrix4x4 matrix = Gizmos.matrix;
		Gizmos.matrix = matrix * Matrix4x4.TRS(parent.position, parent.rotation, Vector3.one);
		Gizmos.color = Color.green;
		Gizmos.DrawSphere(localPosition, 1f);
		Gizmos.DrawLine(localPosition, localPosition + localVelocity * velocityScale);
		Gizmos.matrix = matrix;
	}
}
