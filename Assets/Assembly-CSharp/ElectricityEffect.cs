using UnityEngine;

[RequireComponent(typeof(OWRenderer))]
public class ElectricityEffect : MonoBehaviour
{
	[SerializeField]
	private Vector2 _startOffset = new Vector2(-1f, -1f);
	[SerializeField]
	private Vector2 _endOffset = new Vector2(1f, 1f);
	[SerializeField]
	private float _duration = 1f;
}
