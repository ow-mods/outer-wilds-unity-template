using System;
using UnityEngine;

[Serializable]
public class DampedSpring2D
{
	public DampedSpringSettings settings = new DampedSpringSettings();
	[HideInInspector]
	public Vector2 velocity = Vector2.zero;

	public DampedSpring2D()
	{
	}

	public DampedSpring2D(float springConstant, float dampingCoefficient, float mass)
	{
		settings.springConstant = springConstant;
		settings.dampingCoefficient = dampingCoefficient;
		settings.mass = mass;
	}

	public DampedSpring2D(float springConstant, float dampingRatio)
	{
		settings.springConstant = springConstant;
		settings.dampingRatio = dampingRatio;
	}
}
