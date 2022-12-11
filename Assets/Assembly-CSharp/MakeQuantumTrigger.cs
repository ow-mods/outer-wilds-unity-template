using UnityEngine;

[RequireComponent(typeof(OWTriggerVolume))]
public class MakeQuantumTrigger : MonoBehaviour
{
	[SerializeField]
	private QuantumObject[] _quantumObjects;
	[SerializeField]
	private bool _undoOnExit;
}
