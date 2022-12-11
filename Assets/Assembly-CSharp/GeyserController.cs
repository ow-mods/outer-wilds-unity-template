using UnityEngine;

public class GeyserController : MonoBehaviour
{
	[SerializeField]
	private bool _activeOnAwake = true;
	[SerializeField]
	private float _activeDuration = 10f;
	[SerializeField]
	private float _inactiveDuration = 10f;
	[SerializeField]
	private QuantumObject _quantumRoot;
}
