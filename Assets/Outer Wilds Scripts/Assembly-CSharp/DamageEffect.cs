using UnityEngine;

public class DamageEffect : MonoBehaviour
{
	public enum ParticleMode
	{
		Burst = 0,
		Continuous = 1,
	}
	
	[SerializeField]
	private OWRenderer[] _decalRenderers = new OWRenderer[0];
	[SerializeField]
	private SkinnedMeshRenderer[] _blendShapeRenderers = new SkinnedMeshRenderer[0];
	[SerializeField]
	private OWLight2[] _glowLights = new OWLight2[0];
	[Space]
	[SerializeField]
	private OWRenderer _patchRenderer;
	[Space]
	[SerializeField]
	private OWLight2 _damageLight;
	[SerializeField]
	private OWRenderer _damageLightRenderer;
	[SerializeField]
	private float _damageLightPulseSpeed = 1f;
	[Space]
	[SerializeField]
	private ParticleSystem _particleSystem;
	[SerializeField]
	private ParticleMode _particleMode;
	[SerializeField]
	private Vector2 _particleBurstCount = new Vector2(10f, 30f);
	[SerializeField]
	private Vector2 _particleBurstDelay = new Vector2(0.1f, 1f);
	[Space]
	[SerializeField]
	private OWAudioSource _particleAudioSource;
}
