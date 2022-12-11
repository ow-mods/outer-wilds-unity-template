using UnityEngine;

[RequireComponent(typeof(Collider))]
public class MultiInteractReceiver : MultipleInteractionVolume
{
	[SerializeField]
	protected float _interactRange = 2f;
	[SerializeField]
	private bool _usableInShip;
}
