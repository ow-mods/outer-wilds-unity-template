using UnityEngine;

public class DamLeakEffect : MonoBehaviour
{
	[SerializeField]
	private float _delay;
	[SerializeField]
	private OWRenderer[] _renderers = new OWRenderer[0];
	[SerializeField]
	private ParticleSystem[] _particles = new ParticleSystem[0];
}
