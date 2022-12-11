using UnityEngine;

public class HUDHelmetAnimator : MonoBehaviour
{
	[SerializeField]
	private Transform _helmetRoot;
	[SerializeField]
	private GameObject _helmetVisuals;
	[SerializeField]
	private MeshRenderer _hudRenderer;
	[Space(10f)]
	[SerializeField]
	private float _helmetMoveSpeed = 1f;
	[Space(10f)]
	[SerializeField]
	private DampedSpring3D _helmetOffsetSpring = new DampedSpring3D();
	[SerializeField]
	private float _jumpImpulse = 0.1f;
	[SerializeField]
	private float _impactImpulseScale = 0.01f;
	[SerializeField]
	private Vector3 _jetpackAccelScale = new Vector3(0.01f, 0.01f, 0.01f);
	[SerializeField]
	private Vector3 _boosterShudderFrequency = new Vector3(30f, 30f, 30f);
	[SerializeField]
	private Vector3 _boosterShudderScale = new Vector3(0.2f, 0.2f, 0.2f);
	[SerializeField]
	private Vector3 _offsetMaxRanges = new Vector3(0.1f, 0.1f, 0.03f);
	[Space(10f)]
	[SerializeField]
	private DampedSpringRadial3D _helmetTwistSpring = new DampedSpringRadial3D();
	[SerializeField]
	private Vector2 _lookTwistSensitivity = Vector2.one;
	[SerializeField]
	private Vector3 _twistMaxRanges = new Vector3(30f, 30f, 0f);
	[Space(10f)]
	[SerializeField]
	private float _hudFlickerOnLength = 1f;
	[SerializeField]
	private float _hudFlickerOutLength = 0.25f;
	[SerializeField]
	private float _hudCalibrationLength = 3f;
	[SerializeField]
	private float _hudCrashLength = 1f;
	[SerializeField]
	private float _hudRebootLength = 2f;
	[Space(10f)]
	[SerializeField]
	private DampedSpring _hudDamageWobbleSpring = new DampedSpring();
	[SerializeField]
	private float _hudDamageWobbleScale = 1f;
	[SerializeField]
	private float _hudDamageFlickerScale = 1f;
	[Space(10f)]
	[SerializeField]
	private ElectricalArc[] _electricalArcs = new ElectricalArc[0];
	[SerializeField]
	private float _electricalArcRadius = 0.1f;
	[Space(10f)]
	[SerializeField]
	private float _hudConversationFadeLength = 0.33f;
}
