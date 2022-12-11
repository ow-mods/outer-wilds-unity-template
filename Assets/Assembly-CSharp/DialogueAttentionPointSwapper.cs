using UnityEngine;

public class DialogueAttentionPointSwapper : MonoBehaviour
{
	[SerializeField]
	private CharacterDialogueTree _dialogueTree;
	[SerializeField]
	private string _nodeName = "";
	[SerializeField]
	private int _dialoguePage;
	[Space]
	[SerializeField]
	private Transform _attentionPoint;
	[SerializeField]
	private Vector3 _attentionPointOffset = Vector3.zero;
	[SerializeField]
	private float _lookEasing = 1f;
}
