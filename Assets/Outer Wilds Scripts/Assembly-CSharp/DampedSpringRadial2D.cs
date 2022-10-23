using System;
using UnityEngine;

[Serializable]
public class DampedSpringRadial2D
{
	public DampedSpringSettings settings = new DampedSpringSettings();
	[HideInInspector]
	public Vector2 velocity = Vector2.zero;

	public DampedSpringRadial2D()
	{
	}

	public DampedSpringRadial2D(float springConstant, float dampingCoefficient, float mass)
	{
		settings.springConstant = springConstant;
		settings.dampingCoefficient = dampingCoefficient;
		settings.mass = mass;
	}

	public DampedSpringRadial2D(float springConstant, float dampingRatio)
	{
		settings.springConstant = springConstant;
		settings.dampingRatio = dampingRatio;
	}
}
