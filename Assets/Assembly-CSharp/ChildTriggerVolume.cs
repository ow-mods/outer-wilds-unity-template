using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ChildTriggerVolume : MonoBehaviour
{
	[SerializeField]
	private bool _entryTrigger;
	[SerializeField]
	private bool _exitTrigger;
}
