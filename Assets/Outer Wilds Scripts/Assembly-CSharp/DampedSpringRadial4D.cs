using System;
using UnityEngine;

[Serializable]
public class DampedSpringRadial4D
{
	public DampedSpringSettings settings = new DampedSpringSettings();
	[HideInInspector]
	public Vector4 velocity = Vector4.zero;

	public DampedSpringRadial4D()
	{
	}

	public DampedSpringRadial4D(float springConstant, float dampingCoefficient, float mass)
	{
		settings.springConstant = springConstant;
		settings.dampingCoefficient = dampingCoefficient;
		settings.mass = mass;
	}

	public DampedSpringRadial4D(float springConstant, float dampingRatio)
	{
		settings.springConstant = springConstant;
		settings.dampingRatio = dampingRatio;
	}
}
