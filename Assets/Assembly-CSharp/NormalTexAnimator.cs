using UnityEngine;

public class NormalTexAnimator : MonoBehaviour
{
	[SerializeField]
	private Vector2 _MainTexDirection = Vector2.up;
	[SerializeField]
	private float _MainTexRate = 0.05f;
	[SerializeField]
	private Vector2 _NormalTexDirection = Vector2.up;
	[SerializeField]
	private float _NormalTexRate = 0.05f;
	[SerializeField]
	private Vector2 _IlluminTexDirection = Vector2.up;
	[SerializeField]
	private float _IlluminTexRate = 0.05f;
}
