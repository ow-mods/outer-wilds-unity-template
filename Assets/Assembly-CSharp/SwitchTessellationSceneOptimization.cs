using UnityEngine;
using Tessellation;

public class SwitchTessellationSceneOptimization : MonoBehaviour
{
	public bool skip;
	[Header("Switch-Specific Settings")]
	[SerializeField]
	protected MeshGroup _tessellationMeshGroup;
	[SerializeField]
	protected int _maxLOD = 8;
	[SerializeField]
	protected int _LODBias;
	[SerializeField]
	protected float _LODRadius = 1f;
}
