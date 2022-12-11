using UnityEngine;
using System;
using System.Collections.Generic;

[AddComponentMenu("Sectors/Sector Proxy", 400)]
public class SectorProxy : MonoBehaviour
{
	[Serializable]
	private struct LightData
	{
		public LightData(Light l, float i) : this()
		{
		}

		public Light light;
		public float originalIntensity;
	}

	[SerializeField]
	[HideInInspector]
	private bool _prebuilt;
	[SerializeField]
	[HideInInspector]
	private List<Renderer> _renderers;
	[SerializeField]
	[HideInInspector]
	private List<SectorProxy.LightData> _lights;
	[SerializeField]
	protected Sector _sector;
	[SerializeField]
	private bool _crossfade = true;
	[SerializeField]
	private float _crossfadeLength = 1f;
	[SerializeField]
	protected Sector _exclusiveSector;
}
