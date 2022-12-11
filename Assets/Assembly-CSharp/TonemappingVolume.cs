using UnityEngine;

public class TonemappingVolume : MonoBehaviour
{
	[SerializeField]
	private int _priority;
	[SerializeField]
	private float _innerRadius = 1f;
	[Space(10f)]
	[SerializeField]
	private Texture2D _lut;
}
