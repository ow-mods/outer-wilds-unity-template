using UnityEngine;

public struct FluidTypeData
{
	public int count;
	public Vector3 relativeVelocity;
	public float density;

	public FluidTypeData(int initCount = 0)
	{
		count = initCount;
		relativeVelocity = Vector3.zero;
		density = 0f;
	}
}
