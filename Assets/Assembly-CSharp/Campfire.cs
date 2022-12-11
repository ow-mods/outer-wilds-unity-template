using UnityEngine;

public class Campfire : MonoBehaviour
{
	public enum State
	{
		UNLIT = 0,
		LIT = 1,
		SMOLDERING = 2,
	}

	[SerializeField]
	private State _initialState = State.LIT;
	[SerializeField]
	private Sector _sector;
	[Space]
	[SerializeField]
	private bool _canSleepHere = true;
	[SerializeField]
	private bool _lookUpWhileSleeping;
	[Space]
	[SerializeField]
	private float _heatConeBottom;
	[SerializeField]
	private float _heatConeTop;
	[SerializeField]
	private float _heatConeRadius;
	[SerializeField]
	private float _heatFalloffDistance;
	[Space]
	[SerializeField]
	private float _logSphereCenter;
	[SerializeField]
	private float _logSphereRadius;
	[SerializeField]
	private float _rockHeight;
	[Space]
	[SerializeField]
	protected OWAudioSource _audio;
	[SerializeField]
	protected OWAudioSource _oneShotAudio;
	[SerializeField]
	private OWLightController _lightController;
	[SerializeField]
	private OWRenderer[] _litRenderers;
	[SerializeField]
	private OWRenderer[] _hideWhileSmolderingRenderers;
	[SerializeField]
	private ParticleSystem[] _smolderingParticles;
	[SerializeField]
	private ParticleSystem[] _litParticles;
	[SerializeField]
	private MeshRenderer _flames;
	[SerializeField]
	private MeshRenderer _embers;
	[SerializeField]
	private MeshRenderer _ash;
	[Space]
	[SerializeField]
	private SingleInteractionVolume _interactVolume;
	[SerializeField]
	private PlayerAttachPoint _attachPoint;
	[SerializeField]
	private HazardVolume _hazardVolume;
	[SerializeField]
	private Transform _burnedSlideReelSocket;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = Color.red;
			Vector3 vector = base.transform.TransformPoint(new Vector3(0f, _heatConeBottom, 0f));
			Vector3 to = base.transform.TransformPoint(new Vector3(0f, _heatConeTop, 0f));
			OWGizmos.DrawWireCircle(vector, base.transform.up, _heatConeRadius);
			Gizmos.DrawLine(vector, to);
			Gizmos.DrawLine(vector + base.transform.right * _heatConeRadius, to);
			Gizmos.DrawLine(vector - base.transform.right * _heatConeRadius, to);
			Gizmos.DrawLine(vector + base.transform.forward * _heatConeRadius, to);
			Gizmos.DrawLine(vector - base.transform.forward * _heatConeRadius, to);
			Gizmos.color = Color.green;
			Gizmos.DrawWireSphere(base.transform.position + base.transform.up * _logSphereCenter, _logSphereRadius);
			OWGizmos.DrawWireCircle(base.transform.position + base.transform.up * _rockHeight, base.transform.up, 0.8f);
		}
	}
}
