using System;
using UnityEngine.Events;
using UnityEngine;

public abstract class DistanceTrigger : SectoredMonoBehaviour
{
	[Serializable]
	public class TriggerEnterEvent : UnityEvent
	{
	}

	[Serializable]
	public class TriggerExitEvent : UnityEvent
	{
	}

	[SerializeField]
	protected float _triggerRadius;
	[SerializeField]
	public TriggerEnterEvent OnTriggerEnter;
	[SerializeField]
	public TriggerExitEvent OnTriggerExit;

	protected void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(base.transform.position, _triggerRadius);
	}
}
