using UnityEngine;

public class SignalDishRingController : SectoredMonoBehaviour
{
	[SerializeField]
	private float _direction = 1f;
	[SerializeField]
	private float _maxSpeed = 60f;
	[SerializeField]
	private OWAudioSource _rotationAudio;
}
