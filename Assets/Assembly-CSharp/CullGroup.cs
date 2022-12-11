using UnityEngine;
using System;
using System.Collections.Generic;

public abstract class CullGroup : MonoBehaviour
{
	[Serializable]
	public struct ParticleSystemPair
	{
		public Renderer renderer;
		public ParticleSystem particleSystem;

		public ParticleSystemPair(Renderer r, ParticleSystem ps)
		{
			renderer = r;
			particleSystem = ps;
		}
	}

	public enum ParticleSystemSuspendMode
	{
		None = 0,
		Pause = 1,
		Stop = 2,
	}

	[SerializeField]
	[HideInInspector]
	private bool _prebuilt;
	[SerializeField]
	[HideInInspector]
	private List<Renderer> _staticRenderers;
	[SerializeField]
	[HideInInspector]
	private List<OWRenderer> _dynamicRenderers;
	[SerializeField]
	[HideInInspector]
	private List<CullGroup.ParticleSystemPair> _particleSystems;
	[SerializeField]
	[HideInInspector]
	private List<StreamingRenderMeshHandle> _streamingMeshes;
	[SerializeField]
	[HideInInspector]
	private List<LODGroup> _lodGroups;
	[SerializeField]
	[HideInInspector]
	private SphereBounds _dynamicSphereBounds;
	[SerializeField]
	[HideInInspector]
	private SphereBounds _finalSphereBounds;
	[SerializeField]
	[HideInInspector]
	private Vector3 _localStaticBoundsCenter;
	[SerializeField]
	[HideInInspector]
	private SphereBounds _staticSphereBounds;
	[SerializeField]
	private bool _crossfade = true;
	[SerializeField]
	private float _crossfadeLength = 1f;
	[SerializeField]
	private bool _occlusionCulling;
	[SerializeField]
	private bool _dynamicCullingBounds;
	[SerializeField]
	private ParticleSystemSuspendMode _particleSystemSuspendMode = ParticleSystemSuspendMode.Stop;
	[SerializeField]
	private bool _waitForStreaming;
}
