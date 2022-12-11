using UnityEngine;

public class ThrusterModel : MonoBehaviour
{
	[SerializeField]
	protected float _maxTranslationalThrust = 10f;
	[SerializeField]
	protected float _maxRotationalThrust = 5f;
	[SerializeField]
	protected float _angularDrag = 0.96f;
	[SerializeField]
	protected bool _usePhysicsToRotate = true;
}
