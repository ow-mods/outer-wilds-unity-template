using UnityEngine;
using UnityEngine.UI;

public class MenuGammaSetting : Menu
{
	[SerializeField]
	private SliderElement _gammaSlider;
	[SerializeField]
	private ButtonWithHotkeyImageElement _closeMenuButton;
	[SerializeField]
	private SubmitAction _closeMenuAction;
	[SerializeField]
	private Image _gammaImageReference;
	[SerializeField]
	private bool _standalone;
	[Space(10f)]
	[SerializeField]
	private AnimationCurve _fadeCurve;
	[SerializeField]
	private float _menuFadeDelay;
	[SerializeField]
	private float _menuFadeDuration = 3f;
	[SerializeField]
	private CanvasGroupFadeController _menuFadeController;
	[Space(10f)]
	[SerializeField]
	private Text _instructionalText;
	[SerializeField]
	private Text _echoesGammaMessage;
}