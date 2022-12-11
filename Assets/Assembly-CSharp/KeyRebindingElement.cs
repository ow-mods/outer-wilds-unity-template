using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Selectable))]
public class KeyRebindingElement : MenuOption
{
	[SerializeField]
	protected RebindableID _rebindID;
	[Space(10f)]
	[SerializeField]
	protected Button _controlButton;
	[SerializeField]
	protected SubmitAction _controlSubmitAction;
	[Space(10f)]
	[SerializeField]
	protected Button _labelButton;
	[Space(10f)]
	[SerializeField]
	protected GameObject _gamepadBindingImage1Obj;
	[SerializeField]
	protected GameObject _gamepadBindingImage2Obj;
	[SerializeField]
	protected Image _gamepadBindingImage1;
	[SerializeField]
	protected Image _gamepadBindingImage2;
	[Space(10f)]
	[SerializeField]
	protected GameObject _keyboardMouseBindingBlockObj;
	[SerializeField]
	protected GameObject _keyboardMouseBindingImage1Obj;
	[SerializeField]
	protected GameObject _keyboardMouseBindingImage2Obj;
	[SerializeField]
	protected Image _keyboardMouseBindingImage1;
	[SerializeField]
	protected Image _keyboardMouseBindingImage2;
}
