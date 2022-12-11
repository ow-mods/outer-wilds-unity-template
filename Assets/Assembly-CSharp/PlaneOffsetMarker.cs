using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(LineRenderer))]
public class PlaneOffsetMarker : MonoBehaviour
{
	[SerializeField]
	private Transform _trackedObject;
	[Space]
	[SerializeField]
	private Color _lineColor = Color.white;
	[SerializeField]
	private float _lineWidth = 10f;
	[SerializeField]
	private float _maxLineWidth = 100f;
	[SerializeField]
	private float _dotFrequency = 100f;
	[Space]
	[SerializeField]
	private Color _gridColor = Color.white;
	[SerializeField]
	private float _gridSize = 100f;
	[SerializeField]
	private float _maxGridSize = 1000f;
	[Space]
	[SerializeField]
	private bool _fade;
	[SerializeField]
	private float _fadeStartDist = 10000f;
	[SerializeField]
	private float _fadeEndDist = 20000f;
	[Space]
	[SerializeField]
	private bool _lockOnFade;
	[SerializeField]
	private float _lockOnFadeLength = 1f;
}
