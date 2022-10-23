using UnityEngine;

[RequireComponent(typeof(ImpactSensor))]
public class MapSatelliteStateController : SectoredMonoBehaviour
{
	public enum MapSatelliteState
	{
		NORMAL,
		OFF_COURSE,
		BROKEN
	}

	[SerializeField]
	private float _velocityNominalChange = 70f;
	[SerializeField]
	private float _impactSpeedLimit = 10f;
	[Space]
	[SerializeField]
	private InitialMotion _motionController;
	[SerializeField]
	private AlignWithTargetBody _alignScript;
	[Space]
	[SerializeField]
	private GameObject[] _damagedEffects;
	[SerializeField]
	private LightFlicker _lightFlicker;
}
