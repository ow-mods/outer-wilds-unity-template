using UnityEngine;

[RequireComponent(typeof(Collider))]
public class InteractReceiver : SingleInteractionVolume
{
	[SerializeField]
	protected float _interactRange = 2f;
	[Space]
	[SerializeField]
	private bool _checkViewAngle;
	[SerializeField]
	private float _maxViewAngle = 180f;
	[Space]
	[SerializeField]
	private bool _usableInShip;
}
