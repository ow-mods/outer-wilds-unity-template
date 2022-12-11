using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Selectable))]
public class TabbedNavigation : MonoBehaviour
{
	[SerializeField]
	protected bool _enableOnlyWhenOnKeyboard;
	[SerializeField]
	protected Selectable _tabForwardSelectable;
	[SerializeField]
	protected Selectable _tabBackwardSelectable;
}
