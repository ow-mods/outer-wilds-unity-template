using UnityEngine;

public class ShipComponent : MonoBehaviour
{
	[SerializeField]
	protected UITextType _componentName = UITextType.SatelliteNodeName;
	[SerializeField]
	protected DamageEffect _damageEffect;
	[SerializeField]
	protected float _repairTime = 3f;
	[SerializeField]
	protected AnimationCurve _damageProbabilityCurve = GetDefaultProbabilityCurve();
	[Space(10f)]
	[SerializeField]
	protected Collider _repairCollider;
	[SerializeField]
	protected bool _persistentCollider;
	[SerializeField]
	protected bool _internalRepairPoint;

	private static AnimationCurve GetDefaultProbabilityCurve()
	{
		return new AnimationCurve(new Keyframe(0f, 0f, float.PositiveInfinity, float.PositiveInfinity), new Keyframe(30f, 0.33f, float.PositiveInfinity, float.PositiveInfinity), new Keyframe(100f, 0.5f, float.PositiveInfinity, float.PositiveInfinity), new Keyframe(200f, 1f, float.PositiveInfinity, float.PositiveInfinity))
		{
			preWrapMode = WrapMode.ClampForever,
			postWrapMode = WrapMode.ClampForever
		};
	}
}
