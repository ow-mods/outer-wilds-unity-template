using UnityEngine;

public abstract class NoiseMaker : MonoBehaviour
{
	protected float _noiseRadius;
	private float _lastFogWarpTime;

	public float GetNoiseRadius()
	{
		if (!(Time.time - _lastFogWarpTime < 0.5f))
		{
			return _noiseRadius;
		}
		return 0f;
	}

	private void OnDrawGizmosSelected()
	{
		OWRigidbody attachedOWRigidbody = GetComponent<OWRigidbody>() ?? GetComponentInParent<OWRigidbody>();
		if (attachedOWRigidbody != null)
		{
			Gizmos.color = Color.red;
			Gizmos.DrawWireSphere(attachedOWRigidbody.GetPosition(), GetNoiseRadius());
		}
	}
}
