using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class SolarFlareController : MonoBehaviour
{
	[SerializeField]
	private float _lifetimeScale = 1f;
	[SerializeField]
	private Vector3 _scaleFactor = Vector3.one;
	[SerializeField]
	private Vector2 _uvScrollSpeed = Vector2.zero;
	[SerializeField]
	private AnimationCurve _alphaOverLifetime = AnimationCurve.Linear(0f, 1f, 1f, 0f);
	[SerializeField]
	private AnimationCurve _maskCutoffOverLifetime = AnimationCurve.Linear(0f, 0f, 1f, 0f);
}
