using UnityEngine;

public class NomaiInterfaceOrb : SectoredMonoBehaviour
{
	[SerializeField]
	private Collider _interactibleCollider;
	[SerializeField]
	private SphereCollider _physicalCollider;
	[Space]
	[SerializeField]
	private Renderer _glowRenderer;
	[SerializeField]
	private Renderer _extraGlowRenderer;
	[SerializeField]
	private Light _glowLight;
	[SerializeField]
	private Light _extraGlowLight;
	[SerializeField]
	[ColorUsage(false, true)]
	private Color _draggingGlowColor = Color.white;
	[Space]
	[SerializeField]
	private float _startDragDist = 5f;
	[SerializeField]
	private float _cancelDragDist = 15f;
	[SerializeField]
	private float _maxSpeed = 5f;
	[Space]
	[SerializeField]
	private GameObject _slotRoot;
	[SerializeField]
	private bool _freezeLocalZAxis;
	[SerializeField]
	private bool _freezeLocalRotation;
	[SerializeField]
	private bool _isQuantum;
	[SerializeField]
	private bool _isOnFragment;
	[Space]
	[SerializeField]
	private bool _applyForcesWhileMoving;
	[SerializeField]
	private OWRail[] _safetyRails;
	[SerializeField]
	private float _maxRailDistance;
}
