using UnityEngine;

public class RingRiverFluidVolume : FluidVolume
{
	[Space]
	[SerializeField]
	private bool _debugIgnoreCurrents;
	[SerializeField]
	private bool _updateMarkers;
	[Space]
	[SerializeField]
	private float _defaultSpeed;
	[SerializeField]
	private float _densityForPlayer = 60f;
	[SerializeField]
	private float _buoyancyDensity = 1.1f;
	[Space]
	[SerializeField]
	private GameObject _preFloodFlowMarkers;
	[SerializeField]
	private GameObject _postFloodFlowMarkers;
	[Space]
	[SerializeField]
	private GameObject _undertowVolumesRoot;
	[SerializeField]
	[HideInInspector]
	private bool _flowMarkersCached;
	[SerializeField]
	[HideInInspector]
	private RiverMarkerGroup _preFloodMarkers;
	[SerializeField]
	[HideInInspector]
	private RiverMarkerGroup _postFloodMarkers;
}
