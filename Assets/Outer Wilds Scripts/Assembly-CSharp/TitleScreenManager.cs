using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TitleScreenManager : MonoBehaviour
{
	[SerializeField]
	private TitleScreenAnimation _cameraController;
	[SerializeField]
	private ProfileMenuManager _profileMenuManager;
	[SerializeField]
	private TitleButtonPrompt _titleButtonPrompt;
	[SerializeField]
	private TitleAnimationController _gfxController;
	[SerializeField]
	private CanvasGroup _titleMenuRaycastBlocker;
	[SerializeField]
	private InputUpdateNotifier _inputUpdateNotifier;
	[SerializeField]
	private TitleCodeInputManager _titleCodeManager;
	[Space(10f)]
	[SerializeField]
	private Menu _mainMenu;
	[SerializeField]
	private Menu _optionsMenu;
	[SerializeField]
	private PopupMenu _okCancelPopup;
	[Space(10f)]
	[Header("Main Menu Selectables")]
	[SerializeField]
	private Selectable _newGameButton;
	[SerializeField]
	private Selectable _resumeGameButton;
	[SerializeField]
	private Selectable _profileMenuButton;
	[SerializeField]
	private Selectable _accountPickerButton;
	[SerializeField]
	private Selectable _optionsButton;
	[SerializeField]
	private Selectable _creditsButton;
	[Header("Main Menu Submit Actions")]
	[SerializeField]
	private SubmitActionLoadScene _newGameAction;
	[SerializeField]
	private SubmitActionLoadScene _resumeGameAction;
	[SerializeField]
	private SubmitActionConfirmInput _profileInputSubmitAction;
	[SerializeField]
	private SubmitActionAccountPicker _accountPickerSubmitAction;
	[SerializeField]
	private SubmitActionLoadScene _creditsAction;
	[SerializeField]
	private SubmitAction _resetGameAction;
	[Header("Main Menu Game Objects")]
	[SerializeField]
	private GameObject _resumeGameObject;
	[SerializeField]
	private GameObject _newGameObject;
	[SerializeField]
	private GameObject _profileMenuObject;
	[SerializeField]
	private GameObject _accountPickerObject;
	[SerializeField]
	private GameObject _creditsObject;
	[SerializeField]
	private GameObject _resetGameObject;
	[SerializeField]
	private GameObject _exitGameObject;
	[Space]
	[SerializeField]
	private Text _gameVersionTextDisplay;
	[SerializeField]
	private Text _copyrightTextDisplay;
	[SerializeField]
	private Text _gamertagDisplay;
	[SerializeField]
	private Text[] _mainMenuTextFields;
	[Space]
	[SerializeField]
	private GameObject _disconnectedGameObject;
}