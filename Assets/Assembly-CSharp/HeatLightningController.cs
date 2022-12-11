using UnityEngine;

[RequireComponent(typeof(Light))]
public class HeatLightningController : MonoBehaviour
{
	[SerializeField]
	private float _minflashDuration = 0.5f;
	[SerializeField]
	private float _maxflashDuration = 1.5f;
	[SerializeField]
	private float _minIntensity = 0.5f;
	[SerializeField]
	private float _maxIntensity = 2f;
	[SerializeField]
	private float _minFlashInterval = 5f;
	[SerializeField]
	private float _maxFlashInterval = 15f;
}
