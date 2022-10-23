using UnityEngine;

public class QuantumMoon : QuantumObject
{
	[SerializeField]
	private float _fogRadius = 105f;
	[SerializeField]
	private float _fogThickness = 5f;
	[SerializeField]
	private float _fogRolloffDistance = 5f;
	[SerializeField]
	private float _eyeStateFogOffset;
	[Space]
	[SerializeField]
	private GameObject[] _deactivateAtEye;
	[SerializeField]
	private OWCollider _noStateGroundCollider;
	[SerializeField]
	private Transform _outerCloudTransform;
	[SerializeField]
	private FogOverrideVolume _fogOverride;
	[SerializeField]
	private SunOverrideVolume _sunOverride;
	[SerializeField]
	private AudioSignal _quantumSignal;
	[SerializeField]
	private ReferenceFrameVolume _referenceFrameVolume;
	[SerializeField]
	private Transform _vortexReturnPivot;
	[SerializeField]
	private SphereShape _interiorVolumeShape;
	[SerializeField]
	private OWAudioSource _vortexAudio;
	[Space]
	[SerializeField]
	private Transform _probeAnchorPoint;
	[SerializeField]
	private OWTriggerVolume _probeShipTrigger;
	[SerializeField]
	private SphereShape _sectorShape;
	[SerializeField]
	private VisibilityTracker _visibilityTracker;
	[SerializeField]
	private QuantumShrine _shrine;
	[SerializeField]
	private GameObject[] _quantumShrineProxyRenderers;
	[SerializeField]
	private float _sphereCheckRadius = 500f;
	[SerializeField]
	private GameObject[] _states;
	[SerializeField]
	private QuantumDarkTrigger[] _darkTriggers;
	[SerializeField]
	private string _revealFactID;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.white;
		Gizmos.DrawWireSphere(base.transform.position, _fogRadius);
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(base.transform.position, _sphereCheckRadius);
		Gizmos.color = new ColorHSV(277f, 1f, 1f).ToColorRGB();
		OWGizmos.DrawWireCircle(base.transform.position, Vector3.up, _maxSnapshotLockRange);
		OWGizmos.DrawBillboardedWireCircle(base.transform.position, _maxSnapshotLockRange);
	}
}
