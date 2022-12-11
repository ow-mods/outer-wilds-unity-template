using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Canvas))]
public class PopupTwoOptionMenu : Menu
{
	[SerializeField]
	protected SubmitAction _actionOne;
	[SerializeField]
	protected SubmitAction _actionTwo;
	[SerializeField]
	protected ButtonWithHotkeyImageElement _buttonOne;
	[SerializeField]
	protected ButtonWithHotkeyImageElement _buttonTwo;
	[Header("Root Canvas, cannot be the same as the Canvas on PopupMenu")]
	[SerializeField]
	protected Canvas _rootCanvas;
}
