using UnityEngine;

public class OWRingRiverCollider : OWCapsuleCollider
{
	[SerializeField]
	private float _rampStartDegrees;
	[SerializeField]
	private float _rampEndDegrees;
	[SerializeField]
	private AnimationCurve _rampCurve;
	[Space]
	[SerializeField]
	private float _waveDeltaDegrees = 5f;
	[SerializeField]
	private AnimationCurve _waveFrontCurve;
	[SerializeField]
	private AnimationCurve _waveToDamCurve;
	[SerializeField]
	private AnimationCurve _damDrainCurve;
	[SerializeField]
	private AnimationCurve _downhillElevationToSpeedCurve;
	[Space]
	[SerializeField]
	private float _innerRadiusLow;
	[SerializeField]
	private float _innerRadiusHigh;
	[SerializeField]
	private float _innerRadiusFinal;
	[Space]
	[SerializeField]
	private float _outerRadius;
	
	private float _floodLerp;

	public float GetFloodLerp()
	{
		return _floodLerp;
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.cyan;
		Quaternion quaternion = Quaternion.AngleAxis(_rampStartDegrees, base.transform.up);
		Vector3 vector = base.transform.position + base.transform.forward * 300f;
		Gizmos.DrawLine(base.transform.position, quaternion * vector);
		Quaternion quaternion2 = Quaternion.AngleAxis(_rampEndDegrees, base.transform.up);
		Vector3 vector2 = base.transform.position + base.transform.forward * 300f;
		Gizmos.DrawLine(base.transform.position, quaternion2 * vector2);
		Gizmos.DrawLine(base.transform.position, base.transform.position + base.transform.forward * 300f);
	}
}
