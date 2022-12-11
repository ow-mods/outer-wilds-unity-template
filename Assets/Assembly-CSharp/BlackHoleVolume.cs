using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class BlackHoleVolume : VanishVolume
{
	[SerializeField]
	private SingularityController _singularityController;
	[Header("Audio")]
	[SerializeField]
	private Sector _audioSector;
	[SerializeField]
	private OWAudioSource _emissionSource;
}
