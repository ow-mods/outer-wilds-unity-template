using UnityEngine;

public class TranslatorScanBeam : MonoBehaviour
{
	[SerializeField]
	private Renderer _projectorRenderer;
	[SerializeField]
	private Renderer _lightVolumeRenderer;
	[Space(10f)]
	[SerializeField]
	private float _focusedBeamWidth = 0.25f;
	[SerializeField]
	private float _maxBeamWidth = 1f;
	[SerializeField]
	private float _maxBeamLength = 10f;
	[SerializeField]
	private float _scanSpeed = 1f;
	[SerializeField]
	private float _scanOffset;
	[SerializeField]
	private float _switchLength = 1f;
	[SerializeField]
	private float _fadeLength = 1f;
}
