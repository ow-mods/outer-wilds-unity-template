using UnityEngine;

public abstract class OWItem : SectoredMonoBehaviour
{
	[SerializeField]
	protected float _interactRange = 2f;
	[SerializeField]
	private Vector3 _localDropOffset = Vector3.zero;
	[SerializeField]
	private Vector3 _localDropNormal = Vector3.up;
	[SerializeField]
	[HideInInspector]
	private bool _prebuilt;
	[SerializeField]
	[HideInInspector]
	protected OWCollider[] _colliders;
	[SerializeField]
	[HideInInspector]
	protected OWRenderer[] _renderers;
	[SerializeField]
	[HideInInspector]
	protected ParticleSystem[] _particleSystems;
	[SerializeField]
	[HideInInspector]
	protected OWLight2[] _lights;
}
