using UnityEngine;

[RequireComponent(typeof(MenuOption))]
public class PlatformOverrideTooltipText : MonoBehaviour
{
    [SerializeField]
	private MenuOption _menuOption;
	[SerializeField]
	private bool _overrideXboxOne;
	[SerializeField]
	private bool _overridePS4;
	[SerializeField]
	private bool _overridePC;
	[SerializeField]
	private bool _overrideXboxSeries;
	[SerializeField]
	private bool _overridePS5;
	[SerializeField]
	private bool _overrideSwitch;
	[SerializeField]
	private UITextType _tooltipTextType;
}