using UnityEngine;

public class VesselWarpController : MonoBehaviour
{
	[SerializeField]
	private SingularityController _blackHole;
	[SerializeField]
	private SingularityController _whiteHole;
	[Space]
	[SerializeField]
	private OWAudioSource _audioSource;
	[SerializeField]
	private WarpCoreSocket _coreSocket;
	[SerializeField]
	private DirectionalForceVolume _gravityVolume;
	[SerializeField]
	private OWTriggerVolume _bridgeVolume;
	[SerializeField]
	private TransformAnimator _cageAnimator;
	[SerializeField]
	private OWTriggerVolume _cageTrigger;
	[SerializeField]
	private OWAudioSource _cageLoopingAudio;
	[Space]
	[SerializeField]
	private NomaiCoordinateInterface _coordinateInterface;
	[SerializeField]
	private NomaiWarpPlatform _sourceWarpPlatform;
	[SerializeField]
	private NomaiWarpPlatform _targetWarpPlatform;
	[Space]
	[SerializeField]
	private NomaiInterfaceSlot _coordinatePowerSlot;
	[SerializeField]
	private NomaiInterfaceSlot _warpPlatformPowerSlot;
	[SerializeField]
	private NomaiInterfaceSlot _warpVesselSlot;
	[Space]
	[SerializeField]
	private NomaiEnergyCable _coordinateCable;
	[SerializeField]
	private NomaiEnergyCable _warpPlatformCable;
	[SerializeField]
	private NomaiEnergyCable _coreCable;
	[Space]
	[SerializeField]
	private OWAudioSource _blackHoleOneShot;
	[SerializeField]
	private OWAudioSource _whiteHoleOneShot;
	[Space]
	[SerializeField]
	private Transform _defaultPlayerWarpPoint;
}
