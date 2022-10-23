using UnityEngine;
using UnityEngine.UI;

public class SignalscopeUI : MonoBehaviour
{
	[SerializeField]
	private Canvas _signalscopeCanvas;
	[SerializeField]
	private LineRenderer _waveformRenderer;
	[SerializeField]
	private Image _leftBoundLine;
	[SerializeField]
	private Image _rightBoundLine;
	[SerializeField]
	private Text _signalscopeLabel;
	[SerializeField]
	private float _amplitude = 1f;
	[SerializeField]
	private bool _showFrequencyLabel = true;
	[SerializeField]
	private Text _distanceLabel;
	[SerializeField]
	private RectTransform _signalZoomArrow;
	[SerializeField]
	private float _signalZoomArrowStartRot = 135f;
	[SerializeField]
	private float _signalZoomArrowEndRot = 45f;
	[SerializeField]
	private bool _isPlayerScope;
	[SerializeField]
	private Canvas _signalZoomGroup;
}
