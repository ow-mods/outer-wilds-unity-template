using System;
using UnityEngine;

[Serializable]
public struct Range2D
{
	public Vector2 min;
	public Vector2 max;

	public Range2D(float min_x, float min_y, float max_x, float max_y)
	{
		this.min = new Vector2(min_x, min_y);
		this.max = new Vector2(max_x, max_y);
	}

	public Range2D(Vector2 min, Vector2 max)
	{
		this.min = min;
		this.max = max;
	}
}
