using UnityEngine;

public class TitleAnimationController : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve _fadeCurve;
	[SerializeField]
	private float _logoFadeDelay = 1f;
	[SerializeField]
	private float _logoFadeDuration = 5f;
	[SerializeField]
	private float _echoesFadeDelay = 1f;
	[SerializeField]
	private float _optionsFadeDelay = 2f;
	[SerializeField]
	private float _optionsFadeDuration = 5f;
	[SerializeField]
	private float _optionsFadeSpacing = 0.3f;
	[SerializeField]
	private CanvasGroupFadeController _logoFadeController;
	[SerializeField]
	private CanvasGroupFadeController _echoesFadeController;
	[SerializeField]
	private CanvasGroupFadeController[] _buttonFadeControllers;
	[SerializeField]
	private CanvasGroupFadeController _footerFadeController;
	[SerializeField]
	private Animator _titleAnimator;
}
