using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class OrbitLine : MonoBehaviour
{
	[SerializeField]
	protected AstroObject _astroObject;
	[Space]
	[SerializeField]
	protected int _numVerts = 128;
	[SerializeField]
	protected float _arcDegrees = 360f;
	[SerializeField]
	protected Color _color = Color.white;
	[SerializeField]
	protected float _lineWidth = 10f;
	[SerializeField]
	protected float _maxLineWidth = 100f;
	[Space]
	[SerializeField]
	protected bool _fade;
	[SerializeField]
	protected float _fadeStartDist = 10000f;
	[SerializeField]
	protected float _fadeEndDist = 20000f;
}
