using System;
using UnityEngine;

[Serializable]
public struct SphereBounds
{
	public Vector3 center;
	public float radius;
	
	public SphereBounds(Vector3 sphereCenter, float sphereRadius)
	{
		center = sphereCenter;
		radius = sphereRadius;
	}

	public SphereBounds(Bounds aabbBounds)
	{
		center = aabbBounds.center;
		radius = aabbBounds.extents.magnitude;
	}

	public bool Occludes(SphereBounds other, Vector3 fromPoint)
	{
		Vector3 vector = center - fromPoint;
		Vector3 rhs = other.center - fromPoint;
		float num = 1f / vector.magnitude;
		float num2 = 1f / rhs.magnitude;
		float num3 = Vector3.Dot(vector, rhs) * num * num2;
		float num4 = radius * num;
		float num5 = other.radius * num2;
		float num6 = num3 * num3 + num4 * num4 + num5 * num5;
		float num7 = 2f * num3 * num4 * num5;
		bool num8 = num6 + num7 - 1f >= 0f && num6 - num7 - 1f >= 0f;
		float distanceToPoint = new Plane(vector, center).GetDistanceToPoint(other.center);
		return num8 & (distanceToPoint > other.radius);
	}
}
