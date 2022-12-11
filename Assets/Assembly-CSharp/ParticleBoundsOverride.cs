using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(ParticleSystem))]
public class ParticleBoundsOverride : MonoBehaviour
{
	private ParticleSystemRenderer _renderer;

	[SerializeField]
	private Vector3 _bounds = Vector3.one;

	private void Awake()
	{
		_renderer = GetComponent<ParticleSystemRenderer>();
	}

	private void LateUpdate()
	{
		_renderer.mesh.bounds = new Bounds(Vector3.zero, _bounds);
	}
}
