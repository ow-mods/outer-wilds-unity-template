using UnityEngine;

public class PeepholeDistortImageEffect : MonoBehaviour
{
	[Range(0.01f, 5f)]
	[SerializeField]
	private float _exponent = 1f;
	[Range(0f, 4f)]
	[Tooltip("Intensity multiplier on the x-axis. Set it to 0 to disable distortion on this axis.")]
	[SerializeField]
	private float _xMultiplier = 1f;
	[Range(0f, 4f)]
	[Tooltip("Intensity multiplier on the y-axis. Set it to 0 to disable distortion on this axis.")]
	[SerializeField]
	private float _yMultiplier = 1f;
}
