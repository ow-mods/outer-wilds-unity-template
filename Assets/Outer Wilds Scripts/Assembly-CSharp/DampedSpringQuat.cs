using System;
using UnityEngine;

[Serializable]
public class DampedSpringQuat
{
	public DampedSpringSettings settings = new DampedSpringSettings();
	[HideInInspector]
	public Vector4 velocity = Vector4.zero;

	public DampedSpringQuat()
	{
	}

	public DampedSpringQuat(float springConstant, float dampingCoefficient, float mass)
	{
		settings.springConstant = springConstant;
		settings.dampingCoefficient = dampingCoefficient;
		settings.mass = mass;
	}

	public DampedSpringQuat(float springConstant, float dampingRatio)
	{
		settings.springConstant = springConstant;
		settings.dampingRatio = dampingRatio;
	}
}
