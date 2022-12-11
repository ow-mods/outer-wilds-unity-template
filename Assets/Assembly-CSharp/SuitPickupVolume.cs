using UnityEngine;

public class SuitPickupVolume : MonoBehaviour
{
	[SerializeField]
	private bool _isTrainingSuit;
	[SerializeField]
	private bool _allowSuitReturn = true;
	[Space(10f)]
	[SerializeField]
	private GameObject _suitGeometry;
	[SerializeField]
	private GameObject[] _toolGeometry = new GameObject[0];
	[SerializeField]
	private float _toolPickupDelay = 0.5f;
	[Space(10f)]
	[SerializeField]
	private Collider _suitCollider;
	[Space(10f)]
	[SerializeField]
	private bool _enableSuitOptionsMenu;
}
