using UnityEngine;

[RequireComponent(typeof(CharacterDialogueTree))]
public class HearthianRecorderEffects : MonoBehaviour
{
	[SerializeField]
	private Transform _reel1Transform;
	[SerializeField]
	private float _reel1Speed = 180f;
	[SerializeField]
	private Transform _reel2Transform;
	[SerializeField]
	private float _reel2Speed = 180f;
	[SerializeField]
	private float _reelAcceleration = 1f;
}
