using UnityEngine;

public class PrisonerChoiceDialogue : MonoBehaviour
{
	[SerializeField]
	private QuantumCampsiteController _campsiteController;
	[Space]
	[SerializeField]
	private QuantumInstrument _instrument;
	[SerializeField]
	private CharacterDialogueTree _dialogueTree;
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[Space]
	[SerializeField]
	private VisibilityObject _choiceVisibilityObject;
	[SerializeField]
	private VisibilityObject _campfireVisibilityObject;
	[Space]
	[SerializeField]
	private GameObject _choicePrisonerRoot;
	[SerializeField]
	private GameObject _campfirePrisonerRoot;
}
