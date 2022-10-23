using UnityEngine;

public class EskerAnimController : CharacterAnimController
{
	[Space]
	[SerializeField]
	private OWAudioSource _whistleSource;
	[SerializeField]
	private AnimationCurve _whistleBlendCurve = new AnimationCurve();
	[SerializeField]
	private float _whistleBlendSpeed = 3f;
	[Space]
	[SerializeField]
	private TravelerEyeController _travelerEyeController;
}
