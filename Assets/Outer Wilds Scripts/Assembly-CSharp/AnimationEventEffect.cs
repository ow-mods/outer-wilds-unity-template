using System;
using UnityEngine;

public class AnimationEventEffect : SectoredMonoBehaviour
{
	[Serializable]
	public struct PrefabTransform
	{
		public GameObject prefab;
		[Tooltip("target position/rotation to spawn prefab on, if null will use current gameObject's position/rotation")]
		public Transform targetTransform;
	}

	[Serializable]
	public struct EventActivations
	{
		[SerializeField]
		public AnimationEventEffect.PrefabTransform[] prefabs;
		public ParticleSystem[] ParticleSystems;
		[Space]
		public OWAudioSource audioSource;
		public float audioDelay;
	}

	[SerializeField]
	private EventActivations[] _eventActivations;
}
