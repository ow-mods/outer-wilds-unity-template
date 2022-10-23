using System;
using UnityEngine;

[Serializable]
public class DampedSpring3D
{
	public DampedSpringSettings settings = new DampedSpringSettings();
	[HideInInspector]
	public Vector3 velocity = Vector3.zero;

	public DampedSpring3D()
	{
	}

	public DampedSpring3D(float springConstant, float dampingCoefficient, float mass)
	{
		settings.springConstant = springConstant;
		settings.dampingCoefficient = dampingCoefficient;
		settings.mass = mass;
	}

	public DampedSpring3D(float springConstant, float dampingRatio)
	{
		settings.springConstant = springConstant;
		settings.dampingRatio = dampingRatio;
	}
}
