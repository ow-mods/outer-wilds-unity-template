using UnityEngine;

public class RingRiverPathAudioController : RiverPathAudioController
{
	[Header("River Audio Sources")]
	[SerializeField]
	private RiverPathAudioSource _riverSource;
	[SerializeField]
	private RiverPathAudioSource _reservoirSource;
	[SerializeField]
	private RiverPathAudioSource _coveSource;
	[Header("River Zones")]
	[SerializeField]
	private OWTriggerVolume[] _coveVolumes;
	[SerializeField]
	private float _startReservoirDegrees = 300f;
}
