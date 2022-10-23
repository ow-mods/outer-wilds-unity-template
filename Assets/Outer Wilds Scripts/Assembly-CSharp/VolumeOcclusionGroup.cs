using UnityEngine;
using System;
using System.Collections.Generic;

public class VolumeOcclusionGroup : MonoBehaviour
{
	[Serializable]
	public struct OcclusionVolumeData
	{
		public VolumeOcclusionRenderer occlusionVolume;
		public float originalStrength;

		public OcclusionVolumeData(VolumeOcclusionRenderer vor, float s)
		{
			occlusionVolume = vor;
			originalStrength = s;
		}
	}

	[SerializeField]
	[HideInInspector]
	private bool _prebuilt;
	[SerializeField]
	[HideInInspector]
	private List<VolumeOcclusionGroup.OcclusionVolumeData> _occlusionVolumes;
	[SerializeField]
	[HideInInspector]
	private List<VolumeOcclusionLight> _staticOcclusionLights;
	[SerializeField]
	[HideInInspector]
	private List<OWVolumeOcclusionLight> _dynamicOcclusionLights;
}
