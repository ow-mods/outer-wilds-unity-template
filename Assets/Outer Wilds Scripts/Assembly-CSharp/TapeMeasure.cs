using UnityEngine;

public class TapeMeasure : MonoBehaviour
{
	[SerializeField]
	private Transform _toTransform;
	[SerializeField]
	private bool _printDistanceFromTarget = true;
	[SerializeField]
	private bool _printDeltaFromStart;
	[SerializeField]
	private bool _printRateOfChange;
	[SerializeField]
	private bool _useCentersOfMass = true;
	[SerializeField]
	private bool _recordPositions;
	[SerializeField]
	private float _positionRecordingInterval = 10f;
	[SerializeField]
	private bool _drawPositionTrail;
}
