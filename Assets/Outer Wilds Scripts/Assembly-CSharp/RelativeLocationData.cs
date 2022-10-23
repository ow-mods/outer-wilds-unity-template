using System;
using UnityEngine;

public struct RelativeLocationData
{
	public RelativeLocationData(Vector3 localPosition, Quaternion localRotation, Vector3 localRelativeVelocity)
	{
		this.localPosition = localPosition;
		this.localRotation = localRotation;
		this.localRelativeVelocity = localRelativeVelocity;
	}

	public Vector3 localPosition;
	public Quaternion localRotation;
	public Vector3 localRelativeVelocity;
}
