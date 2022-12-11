using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class IgnoreInitialCollisions : MonoBehaviour
{
	[SerializeField]
	private float _ignoreDuration = 0.01f;
}
