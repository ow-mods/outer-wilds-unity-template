using UnityEngine;
using System;

[RequireComponent(typeof(Light))]
public class CloudLightning : MonoBehaviour
{
	[Serializable]
	public class AnimSettings
	{
		public AnimationCurve radiusScale;
		public AnimationCurve intensityScale;
	}

	[SerializeField]
	private float _lightLength = 1f;
	[SerializeField]
	private float _lightRadius = 100f;
	[SerializeField]
	private float _lightIntensity = 5f;
	[SerializeField]
	private AnimSettings _lightAnimSettings;
}
