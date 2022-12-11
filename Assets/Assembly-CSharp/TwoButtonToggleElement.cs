using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Button))]
public class TwoButtonToggleElement : ToggleElement
{
	[SerializeField]
	private Button _buttonTrue;
	[SerializeField]
	private Button _buttonFalse;
	[Space(10f)]
	[SerializeField]
	private Selectable[] _colorDependentSelectables;
	[SerializeField]
	private Graphic[] _colorDependentGraphics;
}
