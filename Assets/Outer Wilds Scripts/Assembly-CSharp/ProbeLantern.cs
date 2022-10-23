using UnityEngine;

[RequireComponent(typeof(OWLight2))]
public class ProbeLantern : MonoBehaviour
{
	[SerializeField]
	private float _fadeInDuration = 2f;
	[SerializeField]
	private AnimationCurve _fadeInCurve;
	[SerializeField]
	private AnimationCurve _fadeOutCurve;
	[Space(10f)]
	[SerializeField]
	private OWEmissiveRenderer _emissiveRenderer;
}
