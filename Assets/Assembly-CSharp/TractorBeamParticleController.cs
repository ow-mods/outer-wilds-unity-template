using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class TractorBeamParticleController : MonoBehaviour
{
	[SerializeField]
	private float _lifetimeScalar = 1f;
	[SerializeField]
	private float _sizeScalar = 1f;
}
