using UnityEngine;
using System;
using System.Collections.Generic;

public class LightsCullGroup : MonoBehaviour
{
	[Serializable]
	public struct LightData
	{
		public Light light;
		public float originalIntensity;

		public LightData(Light l, float i)
		{
			light = l;
			originalIntensity = i;
		}
	}

	[SerializeField]
	[HideInInspector]
	private bool _prebuilt;
	[SerializeField]
	[HideInInspector]
	private List<LightsCullGroup.LightData> _staticLights;
	[SerializeField]
	[HideInInspector]
	private List<OWLight2> _dynamicLights;
	[SerializeField]
	[HideInInspector]
	private List<LightLOD> _lightLODs;
}
