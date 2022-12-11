using UnityEngine;

public class CylindricalForceVolume : ForceVolume
{
	[SerializeField]
	private float _acceleration = 10f;
	[SerializeField]
	private Vector3 _localAxis = Vector3.up;
	[SerializeField]
	private bool _playGravityCrystalAudio;
}
