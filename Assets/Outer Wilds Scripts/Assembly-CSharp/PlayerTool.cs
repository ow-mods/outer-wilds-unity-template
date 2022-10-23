using UnityEngine;

public class PlayerTool : MonoBehaviour
{
	[SerializeField]
	protected DampedSpringQuat _moveSpring = new DampedSpringQuat();
	[SerializeField]
	protected Transform _stowTransform;
	[SerializeField]
	protected Transform _holdTransform;
	[SerializeField]
	protected float _arrivalDegrees = 5f;
}
