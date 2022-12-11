using UnityEngine;

[RequireComponent(typeof(OWTriggerVolume))]
[RequireComponent(typeof(SphereShape))]
public class ExplosiveGasVolume : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem _particles;
}
