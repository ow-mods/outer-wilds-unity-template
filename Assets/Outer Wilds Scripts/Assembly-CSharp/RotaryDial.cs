using UnityEngine;

public class RotaryDial : MonoBehaviour
{
	[SerializeField]
	private Transform[] _rotatingElements;
	[Space]
	[SerializeField]
	private int _nbSymbols = 12;
	[SerializeField]
	private int _symbolSelected;
	[SerializeField]
	private float _timeToStartRotating = 0.4f;
	[SerializeField]
	private float _timePerRotation = 0.1f;
	[Space]
	[SerializeField]
	private float _rotationSpeed = 120f;
	[SerializeField]
	private float _anglePrecision = 5f;
	[SerializeField]
	private bool _snapToClosest = true;
	[Space]
	[SerializeField]
	private Material _glowMaterial;
	[SerializeField]
	private MeshRenderer _renderer;
}
