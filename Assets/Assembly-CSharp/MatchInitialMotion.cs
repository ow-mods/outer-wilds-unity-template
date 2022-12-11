using UnityEngine;

[RequireComponent(typeof(OWRigidbody))]
public class MatchInitialMotion : MonoBehaviour
{
	[SerializeField]
	private bool _ignoreAngularVelocity;
	[SerializeField]
	private bool _printMatchVelocity;
}
