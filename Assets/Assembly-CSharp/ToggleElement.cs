using UnityEngine.UI;
using UnityEngine;

public class ToggleElement : MenuValueOption
{
	public enum ToggleState
	{
		STATE_TRUE = 1,
		STATE_FALSE = 0
	}
	
	[SerializeField]
	private Text _displayText;
	[SerializeField]
	private Graphic _toggleGraphic;
	[SerializeField]
	private Button _toggleElementButton;
	[SerializeField]
	private bool _isPreflightChecklist;
}
