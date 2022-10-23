using UnityEngine;

public class EntitlementsManager : MonoBehaviour
{
	public enum AsyncOwnershipStatus
	{
		NotReady = 0,
		Owned = 1,
		NotOwned = 2,
	}

	[SerializeField]
	private PopupMenu _popupMenu;
	[Space(10f)]
	[Header("Test values (editor only)")]
	[Tooltip("Enable this to use test value")]
	[SerializeField]
	private bool _useTestValue;
	[SerializeField]
	private AsyncOwnershipStatus _testValue;
}
