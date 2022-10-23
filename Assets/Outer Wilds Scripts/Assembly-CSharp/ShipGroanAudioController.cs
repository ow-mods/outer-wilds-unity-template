using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ShipGroanAudioController : MonoBehaviour
{
	[SerializeField]
	private float _jerkMagnitudeGroanThreshold = 30f;
	[SerializeField]
	private float _jerkChargeTimeThreshold = 5f;
	[SerializeField]
	private float _secondsPreventGroanAfterThrusterFire = 5f;
}
