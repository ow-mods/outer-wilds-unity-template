using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class MeshProjector : MonoBehaviour
{
	public enum Mode
	{
		PhysicalLayer = 0,
		SingleMesh = 1,
		Hierarchy = 2,
	}

	[SerializeField]
	private Mesh _mesh;
	[SerializeField]
	private Material _material;
	[SerializeField]
	private Mode _mode;
	[SerializeField]
	private GameObject[] _targets = new GameObject[0];
	[SerializeField]
	private Vector2 _size = Vector2.one;
	[SerializeField]
	private float _distance = 1f;
	[SerializeField]
	private Vector2 _uvMin = Vector2.zero;
	[SerializeField]
	private Vector2 _uvMax = Vector2.one;
	[SerializeField]
	private Color _color = Color.white;
	[SerializeField]
	private Vector2 _angleFade = new Vector2(45f, 90f);
	[SerializeField]
	private bool _inheritVertexColors;
	[SerializeField]
	private bool _inheritUV1;
	[SerializeField]
	private bool _inheritUV2;
	[SerializeField]
	private bool _inheritUV3;
	[SerializeField]
	private bool _inheritUV4;
	[SerializeField]
	private bool _offsetFromSurface;
	[SerializeField]
	private float _surfaceOffsetDistance;
}
