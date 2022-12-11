using UnityEngine;

public class DebugFlowTester : MonoBehaviour
{
	[Header("Readout")]
	[SerializeField]
	private float _riverSpeed;
	[Space]
	[SerializeField]
	private bool _snapToSurface;
	[Space]
	[SerializeField]
	private RingRiverFluidVolume _riverFluid;
	[SerializeField]
	private Transform _flowTestTransform;
	[HideInInspector]
	[SerializeField]
	private Vector3 _flowTestPosition = Vector3.zero;
	[HideInInspector]
	[SerializeField]
	private Vector3 _flowTestVelocity = Vector3.zero;
}
