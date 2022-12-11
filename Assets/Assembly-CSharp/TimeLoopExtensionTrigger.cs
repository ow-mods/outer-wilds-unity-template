using UnityEngine;

[RequireComponent(typeof(OWTriggerVolume))]
public class TimeLoopExtensionTrigger : MonoBehaviour
{
	[SerializeField]
	private float _rewindToSecondsRemaining = 385f;
	[SerializeField]
	private float _extraSecondsInLighthouse = 100f;
	[SerializeField]
	private bool _ignoreEarlyEntries;
	[SerializeField]
	private bool _ignoreAfterLighthouseCollapse;
	[Space]
	[SerializeField]
	private TimeLoopExtensionTrigger[] _linkedTriggersToDisable;
}
