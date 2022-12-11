using UnityEngine;

public class PlayerParticlesController : MonoBehaviour
{
	[SerializeField]
	private GameObject[] _footstepParticlePrefabs = new GameObject[24];
	[SerializeField]
	private float _impactParticleMinSpeed = 30f;
	[SerializeField]
	private GameObject[] _impactParticlePrefabs = new GameObject[24];
}
