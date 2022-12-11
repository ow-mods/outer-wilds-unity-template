using UnityEngine;

public abstract class PriorityVolume : EffectVolume
{
	[SerializeField]
	private int _layer;
	[SerializeField]
	private int _priority;
}
