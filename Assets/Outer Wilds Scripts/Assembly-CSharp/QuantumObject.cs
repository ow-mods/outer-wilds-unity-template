using UnityEngine;

public class QuantumObject : VisibilityObject
{
	[SerializeField]
	protected float _maxSnapshotLockRange = 100f;
	[SerializeField]
	protected bool _collapseOnStart = true;
	[SerializeField]
	protected bool _debug;
	[SerializeField]
	protected bool _ignoreRetryQueue;
}
