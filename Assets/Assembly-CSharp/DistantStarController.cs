using UnityEngine;
using System;

public class DistantStarController : MonoBehaviour
{
	[Serializable]
	private class ExplosionCurve
	{
		public AnimationCurve explosionsByTime = new AnimationCurve();
	}

	[SerializeField]
	private float _starsUpdateIntervalInSeconds;
	[SerializeField]
	private GameObject _starExplosionObject;
	[SerializeField]
	private ExplosionCurve StarFieldExplosionCurve;
}
