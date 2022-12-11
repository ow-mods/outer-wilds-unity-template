using UnityEngine;

public class NomaiAirlock : NomaiMultiPartDoor
{
	[Space(10f)]
	[SerializeField]
	private OWTriggerVolume _oxygenVolume;
	[SerializeField]
	private GameObject _underwaterStencil;
	[SerializeField]
	private bool _startOxygenated;
	[SerializeField]
	private OWAudioSource _airSFXAudioSource;
	[SerializeField]
	[Range(0f, 1f)]
	private float _oxygenationPoint;
	[Space]
	[SerializeField]
	private AudioType _airPourInSound = AudioType.NomaiAirLockAirPourIn;
	[SerializeField]
	private AudioType _airPourOutSound = AudioType.NomaiAirLockAirPourOut;
}
