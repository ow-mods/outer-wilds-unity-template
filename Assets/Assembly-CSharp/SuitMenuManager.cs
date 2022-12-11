using UnityEngine;

public class SuitMenuManager : MonoBehaviour
{
	[SerializeField]
	private Menu _mainMenu;
	[Space(10f)]
	[SerializeField]
	private SubmitAction _resetSettingsAction;
	[SerializeField]
	private SubmitAction _resetSettingsActionByCommand;
	[SerializeField]
	private SubmitAction _closeMenuAction;
	[SerializeField]
	private MenuCancelAction _onMenuCancelAction;
	[SerializeField]
	private ButtonWithHotkeyImageElement _resetSettingsFooterButton;
	[SerializeField]
	private ButtonWithHotkeyImageElement _closeMenuFooterButton;
	[SerializeField]
	private ScreenPromptList _promptList;
}
