using UnityEngine;
using Tessellation;

public class TessellatedRenderer : MonoBehaviour
{
	[SerializeField]
	protected MeshGroup _tessellationMeshGroup;
	[SerializeField]
	protected Material[] _materials = new Material[1];
	[SerializeField]
	protected Patch.CullingMode _cullingMode = Patch.CullingMode.Normal;
	[Space]
	[SerializeField]
	protected int _maxLOD = 8;
	[SerializeField]
	protected int _LODBias;
	[SerializeField]
	protected float _LODRadius = 1f;
}
