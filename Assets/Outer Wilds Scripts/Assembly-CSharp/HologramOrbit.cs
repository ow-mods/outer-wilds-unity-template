using UnityEngine;

public class HologramOrbit : MonoBehaviour
{
	[SerializeField]
	private AstroObject.Name _name;
	[SerializeField]
	private bool _startVisible;
	[Header("Eye Orbit")]
	[SerializeField]
	private Transform _outerTransform;
	[SerializeField]
	private Transform _innerTransform;
}
