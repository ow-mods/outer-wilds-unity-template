using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

public class Menu : MonoBehaviour
{
	[FormerlySerializedAs("_menuRoot")]
	[SerializeField]
	protected GameObject _menuActivationRoot;
	[SerializeField]
	protected bool _startEnabled;
	[SerializeField]
	protected Selectable _selectOnActivate;
	[Space(10f)]
	[SerializeField]
	protected GameObject _selectableItemsRoot;
	[Space(10f)]
	[SerializeField]
	protected Menu[] _subMenus;
	[Space(10f)]
	[SerializeField]
	protected MenuOption[] _menuOptions;
	[SerializeField]
	protected bool _setMenuNavigationOnActivate = true;
	[Space(10f)]
	[SerializeField]
	protected TooltipDisplay _tooltipDisplay;
	[SerializeField]
	protected bool _addToMenuStackManager = true;
}
