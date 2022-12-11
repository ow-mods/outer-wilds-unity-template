using UnityEngine;

[RequireComponent(typeof(CullDistanceTracker))]
public class DistanceCullGroup : CullGroup
{
	[SerializeField]
	private int _minLevel;
	[SerializeField]
	private int _maxLevel;
}
