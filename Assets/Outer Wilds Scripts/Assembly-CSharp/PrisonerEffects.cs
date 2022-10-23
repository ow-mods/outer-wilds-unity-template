using UnityEngine;

public class PrisonerEffects : GhostEffects
{
	[Header("Prisoner")]
	[SerializeField]
	private Transform _tableLanternIKTarget;
	[SerializeField]
	private Transform _wallTorchIKTarget;
	[SerializeField]
	private Transform _projectVisionIKTarget;
	[Space]
	[SerializeField]
	private OWAudioSource _handAudioSource;
	[SerializeField]
	private OWAudioSource _foleyAudioSource;
}
