using UnityEngine;

public class MapController : MonoBehaviour
{
	[SerializeField]
	private bool _isTrailerMap;
	[Header("MarkerManager")]
	[SerializeField]
	private MapMarkerManager _mapMarkerManager;
	[Header("Pan")]
	[SerializeField]
	private float _panSpeed = 1f;
	[SerializeField]
	private float _maxPanDistance = 50000f;
	[Header("Yaw")]
	[SerializeField]
	private float _yawSpeed = 1f;
	[SerializeField]
	private float _defaultYawAngle;
	[Header("Pitch")]
	[SerializeField]
	private float _pitchSpeed = 1f;
	[SerializeField]
	private float _minPitchAngle;
	[SerializeField]
	private float _maxPitchAngle = 90f;
	[SerializeField]
	private float _defaultPitchAngle = 70f;
	[Header("Zoom")]
	[SerializeField]
	private float _zoomSpeed = 1f;
	[SerializeField]
	private float _minZoomDistance = 10000f;
	[SerializeField]
	private float _maxZoomDistance = 50000f;
	[SerializeField]
	private float _defaultZoomDist = 40000f;
	[Header("Reveal Movement")]
	[SerializeField]
	private AnimationCurve _revealCurve;
	[SerializeField]
	private float _initialPitchAngle = 90f;
	[SerializeField]
	private float _initialZoomDist = 10000f;
	[SerializeField]
	private float _observatoryRevealDist = 1000f;
	[SerializeField]
	private float _observatoryRevealTwist = 90f;
	[SerializeField]
	private float _defaultRevealLength = 2f;
	[SerializeField]
	private float _observatoryRevealLength = 10f;
	[SerializeField]
	private float _observatoryInteractDelay = 8f;
	[Header("Lock On")]
	[SerializeField]
	private float _lockOnMoveLength = 1f;
	[SerializeField]
	private float _playerFramingScale = 1.25f;
	[SerializeField]
	private float _verticalResetLength = 1f;
	[Header("Grid")]
	[SerializeField]
	private MeshRenderer _gridRenderer;
	[SerializeField]
	private Color _gridColor = Color.white;
	[SerializeField]
	private float _gridSize = 10f;
	[SerializeField]
	private float _gridLockOnLength = 1f;
	[Header("Audio")]
	[SerializeField]
	private OWAudioSource _audioSource;
}
