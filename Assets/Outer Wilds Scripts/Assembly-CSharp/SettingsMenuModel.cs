using UnityEngine;

public class SettingsMenuModel : MonoBehaviour
{
	[SerializeField]
	private SettingsMenuView _view;
	[Space(10f)]
	private SettingsSave _gameSettingsOnActivate;
}
