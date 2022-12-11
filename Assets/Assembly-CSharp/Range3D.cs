using System;
using UnityEngine;

[Serializable]
public struct Range3D
{
	public Vector3 min;

	public Vector3 max;

	public Range3D(float min_x, float min_y, float min_z, float max_x, float max_y, float max_z)
	{
		this.min = new Vector3(min_x, min_y, min_z);
		this.max = new Vector3(max_x, max_y, max_z);
	}

	public Range3D(Vector3 min, Vector3 max)
	{
		this.min = min;
		this.max = max;
	}
}
