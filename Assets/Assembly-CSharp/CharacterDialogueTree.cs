using UnityEngine;

public class CharacterDialogueTree : MonoBehaviour
{
	[SerializeField]
	private TextAsset _xmlCharacterDialogueAsset;
	[SerializeField]
	private Transform _attentionPoint;
	[SerializeField]
	private Vector3 _attentionPointOffset = Vector3.zero;
	[SerializeField]
	private bool _turnOffFlashlight = true;
	[SerializeField]
	private bool _turnOnFlashlight = true;
}
