using UnityEngine;

public class ShipGauge : MonoBehaviour
{
	[SerializeField]
	protected ShipLODTrigger _lodTrigger;
	[Space]
	[SerializeField]
	protected Transform _needleTransform;
	[SerializeField]
	protected float _needleAngleMin;
	[SerializeField]
	protected float _needleAngleMax = 180f;
	[Space]
	[SerializeField]
	protected OWRenderer _indicatorLight;
	[SerializeField]
	protected float _indicatorWarningThreshold = 0.3f;
	[ColorUsage(false, true)]
	[SerializeField]
	protected Color _indicatorWarningColor = new Color(1.5f, 1f, 0.5f);
	[ColorUsage(false, true)]
	[SerializeField]
	protected Color _indicatorCriticalColor = new Color(1.3f, 0.55f, 0.55f);
}
