using UnityEngine;

public class ProbePhotoTarget : VisibilityObject
{
	[SerializeField]
	private float _maxPhotoDistance = 200f;
	[SerializeField]
	private float _baseScore = 10f;
	[SerializeField]
	private string _name = "";
	[SerializeField]
	private float _raycastOffset = 10f;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(base.transform.position, _raycastOffset);
	}
}
