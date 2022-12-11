using UnityEngine;

public class DebugFlowFieldVisualizer : MonoBehaviour
{
	[SerializeField]
	private bool _drawFlowVectors;
	[SerializeField]
	private bool _drawFlowMarkers;
	[SerializeField]
	private int _xResolution = 100;
	[SerializeField]
	private int _yResolution = 30;
	[SerializeField]
	private float _velocityScale = 2f;
	[Space]
	[SerializeField]
	private bool _updateFlowVectors;
	[SerializeField]
	private bool _debugToggleFlood;
	[Space]
	[SerializeField]
	private RingRiverFluidVolume _riverFluid;
	[SerializeField]
	private OWRingRiverCollider _riverCollider;
	[SerializeField]
	private RingRiverController _riverController;
	[SerializeField]
	private DebugFlowVector[,] _debugFlowVectors;
}
