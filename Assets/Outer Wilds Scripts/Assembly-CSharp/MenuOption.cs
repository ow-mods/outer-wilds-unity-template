using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class MenuOption : MonoBehaviour
{
	[SerializeField]
	protected SettingsID _settingId;
	[SerializeField]
	protected Text _label;
	[SerializeField]
	protected Text _secondaryTextField;
	[SerializeField]
	protected UITextType _tooltipTextType;
	[FormerlySerializedAs("_testText")]
	[SerializeField]
	protected string _overrideTooltipText;
	[Space(10f)]
	[FormerlySerializedAs("_enableXbox")]
	[SerializeField]
	private bool _enableXboxOne = true;
	[SerializeField]
	private bool _enableXboxSeriesSX = true;
	[SerializeField]
	private bool _enablePS4 = true;
	[SerializeField]
	private bool _enablePS5 = true;
	[SerializeField]
	private bool _enableSwitch = true;
	[SerializeField]
	private bool _enablePC = true;
	[SerializeField]
	private bool _enableInGame = true;
	[SerializeField]
	private bool _dlcOnly;
	[SerializeField]
	private UITextType _overrideLabelTextPS5Only;
}
