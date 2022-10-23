using UnityEngine;

[RequireComponent(typeof(OWRigidbody))]
public class AlignWithDirection : MonoBehaviour
{
	private enum InterpolationMode
	{
		None = 0,
		Exponential = 1,
		Linear = 2,
		InverseExponential = 3,
	}

	[SerializeField]
	protected Vector3 _localAlignmentAxis = new Vector3(0f, -1f, 0f);
	[SerializeField]
	private InterpolationMode _interpolationMode;
	[SerializeField]
	private float _interpolationRate = 100f;
	[SerializeField]
	private bool _usePhysicsToRotate;
}
