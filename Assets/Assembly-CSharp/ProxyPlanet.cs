using UnityEngine;

public class ProxyPlanet : ProxyBody
{
	[SerializeField]
	protected Renderer _atmosphere;
	[SerializeField]
	protected Renderer _fog;
	[Space]
	[Header("Mie Interpolation")]
	[SerializeField]
	protected float _mieCurveMinDistance = 45000f;
	[SerializeField]
	protected float _mieCurveMaxDistance = 750000f;
	[SerializeField]
	protected float _mieCurveMinVal;
	[SerializeField]
	protected float _mieCurveMaxVal;
	[SerializeField]
	protected AnimationCurve _mieCurve;
	[Space]
	[Header("Fog Interpolation")]
	[SerializeField]
	protected float _fogCurveMinDistance = 45000f;
	[SerializeField]
	protected float _fogCurveMaxDistance = 750000f;
	[SerializeField]
	protected float _fogCurveMinVal;
	[SerializeField]
	protected float _fogCurveMaxVal;
	[SerializeField]
	protected AnimationCurve _fogCurve;
	[Space]
	private Material _atmosphereMaterial;
}
