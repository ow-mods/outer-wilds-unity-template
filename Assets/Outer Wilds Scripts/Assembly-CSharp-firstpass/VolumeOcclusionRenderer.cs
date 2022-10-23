using UnityEngine;

public class VolumeOcclusionRenderer : MonoBehaviour
{
	[SerializeField]
	private Mesh _mesh;
	[SerializeField]
	[Range(0f, 1f)]
	private float _occlusionStrength = 1f;

	private void OnDrawGizmosSelected()
	{
		if (_mesh != null)
		{
			Gizmos.color = new Color(1f, 1f, 1f, 0.2f);
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Gizmos.DrawWireMesh(_mesh);
		}
	}
}
