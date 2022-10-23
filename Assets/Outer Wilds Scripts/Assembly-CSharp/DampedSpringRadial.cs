using System;
using UnityEngine;

[Serializable]
public class DampedSpringRadial
{
	public DampedSpringSettings settings = new DampedSpringSettings();
	[HideInInspector]
	public float velocity;

	public DampedSpringRadial()
	{
	}

	public DampedSpringRadial(float springConstant, float dampingCoefficient, float mass)
	{
		settings.springConstant = springConstant;
		settings.dampingCoefficient = dampingCoefficient;
		settings.mass = mass;
	}

	public DampedSpringRadial(float springConstant, float dampingRatio)
	{
		settings.springConstant = springConstant;
		settings.dampingRatio = dampingRatio;
	}
}
