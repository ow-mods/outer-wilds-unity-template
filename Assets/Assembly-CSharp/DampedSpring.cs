using System;
using UnityEngine;

[Serializable]
public class DampedSpring
{
	public DampedSpringSettings settings = new DampedSpringSettings();
	[HideInInspector]
	public float velocity;

	public DampedSpring()
	{
	}

	public DampedSpring(float springConstant, float dampingCoefficient, float mass)
	{
		settings.springConstant = springConstant;
		settings.dampingCoefficient = dampingCoefficient;
		settings.mass = mass;
	}

	public DampedSpring(float springConstant, float dampingRatio)
	{
		settings.springConstant = springConstant;
		settings.dampingRatio = dampingRatio;
	}
}
