using UnityEngine;

public class PlaytestDiscoveryPrompt : MonoBehaviour
{
	[SerializeField]
	private CloakFieldController _cloakFieldController;
	[SerializeField]
	private GameObject _popupPrefab;
	[Tooltip("whether to actually record some values that need to be recorded. To be turned off when not doing playtest build.")]
	private PopupMenu _menu;
}
