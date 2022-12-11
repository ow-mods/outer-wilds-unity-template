using System;
using UnityEngine;

[Serializable]
public class SplashEffect
{
	public enum TriggerEvent
	{
		OnEntry = 1,
		OnExit = 2,
		OnEntryOrExit = 3,
	}

	public FluidVolume.Type fluidType;
	public float minImpactSpeed = 15f;
	public TriggerEvent triggerEvent = TriggerEvent.OnEntry;
	public GameObject splashPrefab;
	public bool ignoreSphereAligment;
}
