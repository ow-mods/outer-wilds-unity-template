using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Button))]
public class TwoButtonActionElement : MenuOption
{
	private enum ElementSelectables
	{
		UNDEFINED = -1,
		BUTTON_ONE = 1,
		BUTTON_TWO = 0,
	}

	[SerializeField]
	private Button _buttonOne;
	[SerializeField]
	private Button _buttonTwo;
	[Space(10f)]
	[SerializeField]
	private ElementSelectables _selectButtonOnElementSelect = ElementSelectables.BUTTON_ONE;
	[Space(10f)]
	[SerializeField]
	private SubmitAction _submitActionOne;
	[SerializeField]
	private SubmitAction _submitActionTwo;
	[Space(10f)]
	[SerializeField]
	private Selectable[] _colorDependentSelectables;
	[SerializeField]
	private Graphic[] _colorDependentGraphics;
}
