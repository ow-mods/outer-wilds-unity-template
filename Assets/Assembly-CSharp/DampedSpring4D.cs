using System;
using UnityEngine;

[Serializable]
public class DampedSpring4D
{
	public DampedSpringSettings settings = new DampedSpringSettings();
	[HideInInspector]
	public Vector4 velocity = Vector4.zero;

	public DampedSpring4D()
	{
	}

	public DampedSpring4D(float springConstant, float dampingCoefficient, float mass)
	{
		settings.springConstant = springConstant;
		settings.dampingCoefficient = dampingCoefficient;
		settings.mass = mass;
	}

	public DampedSpring4D(float springConstant, float dampingRatio)
	{
		settings.springConstant = springConstant;
		settings.dampingRatio = dampingRatio;
	}
}
