using System;
using UnityEngine;

[Serializable]
public class DampedSpringRadial3D
{
	public DampedSpringSettings settings = new DampedSpringSettings();
	[HideInInspector]
	public Vector3 velocity = Vector3.zero;

	public DampedSpringRadial3D()
	{
	}

	public DampedSpringRadial3D(float springConstant, float dampingCoefficient, float mass)
	{
		settings.springConstant = springConstant;
		settings.dampingCoefficient = dampingCoefficient;
		settings.mass = mass;
	}

	public DampedSpringRadial3D(float springConstant, float dampingRatio)
	{
		settings.springConstant = springConstant;
		settings.dampingRatio = dampingRatio;
	}
}
