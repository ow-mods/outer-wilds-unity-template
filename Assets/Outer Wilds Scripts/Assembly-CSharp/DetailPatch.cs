using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class DetailPatch : MonoBehaviour
{
	public enum Mode
	{
		PhysicalLayer = 0,
		SingleMesh = 1,
		Hierarchy = 2,
	}

	public enum Shape
	{
		Box = 0,
		Cylinder = 1,
	}

	[SerializeField]
	private DetailPalette _palette;
	[SerializeField]
	private Mode _mode;
	[SerializeField]
	private GameObject[] _targets = new GameObject[0];
	[SerializeField]
	private bool _blockable = true;
	[SerializeField]
	private Shape _shape;
	[SerializeField]
	private Vector2 _size = Vector2.one;
	[SerializeField]
	private float _distance = 1f;
	[SerializeField]
	private int _seed;
	[SerializeField]
	private int _count = 10;
	[SerializeField]
	private bool _separation = true;
	[SerializeField]
	private AnimationCurve _distribution = AnimationCurve.Linear(0f, 0f, 1f, 1f);
	[SerializeField]
	private DetailInstance[] _instances = new DetailInstance[0];
	[SerializeField]
	private Mesh _mesh;
	[SerializeField]
	private Material[] _materials = new Material[0];
}
