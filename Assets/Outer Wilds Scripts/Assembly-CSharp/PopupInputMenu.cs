using UnityEngine.UI;
using UnityEngine;

public class PopupInputMenu : PopupMenu
{
	[Space(10f)]
	[SerializeField]
	private InputField _inputField;
	[SerializeField]
	private InputEventListener _inputFieldEventListener;
}
