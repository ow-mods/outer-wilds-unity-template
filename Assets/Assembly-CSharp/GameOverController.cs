using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
	[SerializeField]
	private Canvas _gameOverTextCanvas;
	[Space(10f)]
	[SerializeField]
	private Text _deathText;
	[SerializeField]
	private int _deathTextMaxFontSize;
	[Space(10f)]
	[SerializeField]
	private CanvasGroupAnimator _textAnimator;
	[SerializeField]
	private AnimationCurve _fadeCurve;
	[Space(10f)]
	[SerializeField]
	private CanvasGroupAnimator _whiteFadeAnimator;
	[SerializeField]
	private AnimationCurve _whiteFadeCurve;
}
