using UnityEngine;

[RequireComponent(typeof(FadeChildren))]
public class CreditsFadeSection : CreditsSection
{
	[SerializeField]
	private float _fadeInDuration = 0.5f;
	[SerializeField]
	private float _displayDuration = 1.7f;
	[SerializeField]
	private float _fadeOutDuration = 0.5f;
	[SerializeField]
	private float _waitDuration = 0.5f;
	[SerializeField]
	private FadeChildren _fadeComponent;
	[SerializeField]
	private AnimationCurve _fadeCurve;
}
