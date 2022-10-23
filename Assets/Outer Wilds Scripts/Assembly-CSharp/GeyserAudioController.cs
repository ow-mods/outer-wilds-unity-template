using UnityEngine;

[RequireComponent(typeof(GeyserController))]
public class GeyserAudioController : SectoredMonoBehaviour
{
	[SerializeField]
	private Sector _exclusionSector;
	[Space(10f)]
	[SerializeField]
	private OWAudioSource _audioSourceLoop;
	[SerializeField]
	private OWAudioSource _audioSourceOneShot;
	[Space(10f)]
	[SerializeField]
	private float _geyserOpeningHeight;
	[SerializeField]
	private ParticleSystem _geyserSpoutParticles;

	private void OnDrawGizmosSelected()
	{
		var fluidVolume = this.GetComponentInChildren<GeyserFluidVolume>();
		if (fluidVolume == null) return;
		Gizmos.color = Color.red;
		Gizmos.DrawSphere(fluidVolume.transform.position + fluidVolume.transform.up * _geyserOpeningHeight, 0.5f);
	}
}
