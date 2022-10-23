using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class SplashController : MonoBehaviour
{
	[SerializeField]
	private float _lifetime = 1f;
	[SerializeField]
	private float _delay;
	[SerializeField]
	private AnimationCurve _yOffsetOverLife = AnimationCurve.Linear(0f, 0f, 1f, 1f);
	[SerializeField]
	private AnimationCurve _cutoffOverLife = AnimationCurve.Linear(0f, 0.5f, 1f, 1f);
}
