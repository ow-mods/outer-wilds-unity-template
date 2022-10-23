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
	[SerializeField]
	private bool _enableXbox;
	[SerializeField]
	private bool _enablePS4;
	[SerializeField]
	private bool _enablePC;
	[SerializeField]
	private bool _enableInGame;
	[SerializeField]
	private bool _dlcOnly;
	[SerializeField]
	private UITextType _overrideLabelTextPS5Only;
}
