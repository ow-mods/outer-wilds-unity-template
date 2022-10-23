using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Selectable))]
public class OptionsSelectorElement : MenuValueOption
{
	protected enum Direction
	{
		HORIZONTAL = 0,
		VERTICAL = 1,
	}

	[SerializeField]
	protected Direction _directionality;
	[SerializeField]
	protected bool _loopAround;
	[SerializeField]
	protected string[] _optionsList;
	[SerializeField]
	private UITextType[] _options;
	[SerializeField]
	protected Text _displayText;
	[SerializeField]
	protected UIStyleApplier _optionsBoxStyleApplier;
	[Header("Arrow Selectables")]
	[SerializeField]
	protected Selectable _selectOnUp;
	[SerializeField]
	protected Selectable _selectOnDown;
	[SerializeField]
	protected Selectable _selectOnLeft;
	[SerializeField]
	protected Selectable _selectOnRight;
}
