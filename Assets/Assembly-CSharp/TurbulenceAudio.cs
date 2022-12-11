using System;
using UnityEngine;

[Serializable]
public class TurbulenceAudio
{
	[SerializeField]
	private OWAudioSource _audioSource;
	[SerializeField]
	private float _maxDensity = 5f;
	[SerializeField]
	private float _lowerSpeedLimit = 20f;
	[SerializeField]
	private float _upperSpeedLimit = 40f;
	[SerializeField]
	private float _easeRate = 3f;
}
