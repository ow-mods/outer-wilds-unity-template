using UnityEngine;

public class HeightmapAmbientLight : SectoredMonoBehaviour
{
	[Space]
	[SerializeField]
	private Texture2D _heightmap;
	[SerializeField]
	private Vector3 _size = new Vector3(100f, 100f, 100f);
	[SerializeField]
	private float _falloff = 10f;
	[Space]
	[SerializeField]
	[Range(0f, 8f)]
	private float _intensity = 1f;
	[SerializeField]
	private Color _color = new Color(1f, 1f, 1f, 1f);
	[SerializeField]
	private Texture2D _gradient;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.matrix = Matrix4x4.TRS(base.transform.position, base.transform.rotation, _size);
			Gizmos.color = Color.yellow;
			Gizmos.DrawWireCube(new Vector3(0f, 0f, 0.5f), Vector3.one);
		}
	}
}
