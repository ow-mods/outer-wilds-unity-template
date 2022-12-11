using UnityEngine;

public class QuantumState : MonoBehaviour
{
	[SerializeField]
	private int _probability;
	[SerializeField]
	private bool _checkPlayerDistance;
	[SerializeField]
	private float _maxPlayerDistance;
	[Space]
	[SerializeField]
	private Light _blockingLight;
}
