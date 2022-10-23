using System;
using UnityEngine;

[Serializable]
public class ReferenceFrame
{
	public ReferenceFrame(OWRigidbody attachedOWRigidbody)
	{
	}

	[SerializeField]
	private float _minSuitTargetDistance;
	[SerializeField]
	private float _maxTargetDistance;
	[SerializeField]
	private float _autopilotArrivalDistance;
	[SerializeField]
	private float _autoAlignmentDistance;
	[SerializeField]
	private bool _hideLandingModePrompt;
	[Space(10f)]
	[SerializeField]
	private bool _matchAngularVelocity;
	[SerializeField]
	private float _minMatchAngularVelocityDistance;
	[SerializeField]
	private float _maxMatchAngularVelocityDistance;
	[Space(10f)]
	[SerializeField]
	private float _bracketsRadius;

	public float GetAutopilotArrivalDistance()
	{
		return _autopilotArrivalDistance;
	}

	public float GetAutoAlignmentDistance()
	{
		return _autoAlignmentDistance;
	}

	public float GetMinSuitTargetDistance()
	{
		return _minSuitTargetDistance;
	}

	public float GetMaxTargetDistance()
	{
		return _maxTargetDistance;
	}

	public float GetMinMatchAngularVelocityDistance()
	{
		return _minMatchAngularVelocityDistance;
	}

	public float GetMaxMatchAngularVelocityDistance()
	{
		return _maxMatchAngularVelocityDistance;
	}

	public float GetBracketsRadius()
	{
		return _bracketsRadius;
	}
}
