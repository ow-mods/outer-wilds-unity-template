using UnityEngine;

public class Equalizer : MonoBehaviour
{
	[SerializeField]
	private Renderer[] _barRenderers;
	[SerializeField]
	private AnimationCurve[] _waveforms;
	[SerializeField]
	private float _waveformSpeed = 1f;
	[SerializeField]
	private float _waveformMagnitude = 1f;
	[SerializeField]
	private float _noiseSpeed = 1f;
	[SerializeField]
	private float _noiseMagnitude = 1f;
}
