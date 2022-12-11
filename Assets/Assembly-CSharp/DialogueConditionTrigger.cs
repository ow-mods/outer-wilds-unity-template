using UnityEngine;

public class DialogueConditionTrigger : MonoBehaviour
{
	[SerializeField]
	private string _conditionID = string.Empty;
	[SerializeField]
	private bool _player = true;
	[SerializeField]
	private bool _probe;
	[SerializeField]
	private bool _persistentCondition;
}
