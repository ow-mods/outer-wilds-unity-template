using UnityEngine;

public class ElectricityVolume : HazardVolume
{
	[Space]
	[SerializeField]
	private float _shockRepeatTime = 1f;
	[Space]
	[SerializeField]
	private float _kickback = 10f;
	[SerializeField]
	private bool _shellKickback;
	[SerializeField]
	private float _shellThickness = 1f;
	[Space]
	[SerializeField]
	private OWAudioSource[] _shockAudioPool;
}
