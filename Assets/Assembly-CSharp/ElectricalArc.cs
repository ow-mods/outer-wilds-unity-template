using UnityEngine;

public class ElectricalArc : MonoBehaviour
{
	public enum Preset
	{
		None,
		Auto,
		Small,
		Medium,
		Large
	}

	public enum Mode
	{
		Looping = 0,
		Jumping = 1,
		OneShot = 2,
	}

	public enum Dimension
	{
		_1D = 1,
		_2D = 2,
		_3D = 3,
	}

	[Header("Targets")]
	[SerializeField]
	private Transform _startTransform;
	[SerializeField]
	private Vector3 _startLocalPosition = Vector3.zero;
	[SerializeField]
	private Transform _endTransform;
	[SerializeField]
	private Vector3 _endLocalPosition = Vector3.zero;
	[Header("Line Parameters")]
	[SerializeField]
	private Material _material;
	[SerializeField]
	private int _resolution = 16;
	[SerializeField]
	private float _width = 0.1f;
	[Header("Arc Parameters")]
	[SerializeField]
	private Mode _mode;
	[SerializeField]
	private float _frequency = 1f;
	[SerializeField]
	private float _intensity = 1f;
	[SerializeField]
	private float _speed = 1f;
	[SerializeField]
	private float _scrollSpeed = 1f;
	[SerializeField]
	private float _jumpTime = 1f;
	[SerializeField]
	private Vector3 _jumpDirection = Vector3.zero;
	[Header("Noise Parameters")]
	[SerializeField]
	private Dimension _dimension = Dimension._2D;
	[SerializeField]
	private Vector3 _dimensionScale = Vector3.one;
	[SerializeField]
	private int _octaves = 1;
}
