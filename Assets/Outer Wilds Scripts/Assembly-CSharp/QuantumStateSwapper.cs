using UnityEngine;

[RequireComponent(typeof(QuantumObject))]
public class QuantumStateSwapper : MonoBehaviour
{
	[SerializeField]
	private bool _ignoreFailedCollapses;
}
