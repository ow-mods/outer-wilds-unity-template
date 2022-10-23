using UnityEngine;
using System;

[RequireComponent(typeof(NomaiComputer))]
public class NomaiComputerSlotInterface : MonoBehaviour
{
	[Serializable]
	private struct ComputerEvent
	{
		public enum Type
		{
			DisplayEntry = 0,
			DisplayAllEntries = 1,
			ClearEntry = 2,
			ClearAllEntries = 3,
			Wait = 4,
		}

		public Type type;
		public int entryID;
		public float waitTime;
	}

	[SerializeField]
	private NomaiInterfaceSlot _slot;
	[SerializeField]
	private ComputerEvent[] _onActivate;
	[SerializeField]
	private ComputerEvent[] _onDeactivate;

	private void OnDrawGizmosSelected()
	{
		if (_slot != null)
		{
			Gizmos.color = Color.cyan;
			Gizmos.DrawLine(base.transform.position, _slot.transform.position);
		}
	}
}
