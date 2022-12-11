using UnityEngine;

public class RapidsHazardVolume : HazardVolume
{
	[Header("Torque")]
	[SerializeField]
	private float _minTorqueDelay = 0.4f;
	[SerializeField]
	private float _maxTorqueDelay = 0.8f;
	[SerializeField]
	private float _torqueAcceleration = 3.6f;
	[SerializeField]
	private float _minTorqueDuration = 0.5f;
	[SerializeField]
	private float _maxTorqueDuration = 1f;
}
