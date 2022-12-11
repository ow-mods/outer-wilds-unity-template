using UnityEngine;

[RequireComponent(typeof(QuantumObject))]
public class QuantumShuffleObject : QuantumObject
{
	[SerializeField]
	private Transform[] _shuffledObjects;
}
