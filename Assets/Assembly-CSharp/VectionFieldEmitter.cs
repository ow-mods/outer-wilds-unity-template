using UnityEngine;

public class VectionFieldEmitter : MonoBehaviour
{
	public enum EmitDirection
	{
		Random = 0,
		Directional = 1,
		Radial = 2,
		Gravity = 3,
	}

	[SerializeField]
	private Transform _emitterTransform;
	[SerializeField]
	private float _fieldRadius = 10f;
	[SerializeField]
	private int _particleCount = 10;
	[SerializeField]
	private bool _emitOnLeadingEdge = true;
	[SerializeField]
	private EmitDirection _emitDirection;
	[SerializeField]
	private Vector3 _directionalDir = Vector3.zero;
	[SerializeField]
	private bool _reverseDir;
	[SerializeField]
	private ForceVolume[] _affectingForces;
	[SerializeField]
	private float _forceMultiplier = 1f;
	[SerializeField]
	private bool _applyForcePerParticle;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = Color.green;
			Gizmos.DrawWireSphere((_emitterTransform != null) ? _emitterTransform.position : base.transform.position, _fieldRadius);
		}
	}
}
