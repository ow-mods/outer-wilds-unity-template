using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Selectable))]
public class ListSelectorElement : OptionsSelectorElement
{
	[Space(10f)]
	[SerializeField]
	protected LayoutElement _wholeControlLayoutElement;
	[SerializeField]
	protected HorizontalLayoutGroup _wholeElementHorzLayoutGroup;
	[Space(10f)]
	[SerializeField]
	protected LayoutElement _listSectionLayoutElement;
	[SerializeField]
	protected ToggleElement _templateToggle;
	[SerializeField]
	protected VerticalLayoutGroup _toggleListLayoutGroup;
}
