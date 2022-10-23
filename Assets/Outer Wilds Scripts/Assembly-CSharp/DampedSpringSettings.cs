using System;
using UnityEngine;

[Serializable]
public class DampedSpringSettings
{
	public float springConstant = 1f;
	public float dampingCoefficient = 1f;
	public float mass = 1f;
	public float dampingRatio
	{
		get
		{
			return dampingCoefficient / (2f * Mathf.Sqrt(springConstant * mass));
		}
		set
		{
			dampingCoefficient = value * (2f * Mathf.Sqrt(springConstant * mass));
		}
	}
}
