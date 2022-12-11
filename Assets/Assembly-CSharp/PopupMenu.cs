using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Canvas))]
public class PopupMenu : Menu
{
	[SerializeField]
	protected Text _labelText;
	[SerializeField]
	protected SubmitAction _cancelAction;
	[SerializeField]
	protected SubmitAction _okAction;
	[SerializeField]
	protected ButtonWithHotkeyImageElement _cancelButton;
	[SerializeField]
	protected ButtonWithHotkeyImageElement _confirmButton;
	[Header("Root Canvas, cannot be the same as the Canvas on PopupMenu")]
	[SerializeField]
	protected Canvas _rootCanvas;
}
