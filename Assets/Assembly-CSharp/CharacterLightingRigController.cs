using UnityEngine;

[ExecuteInEditMode]
public class CharacterLightingRigController : SectoredMonoBehaviour
{
	[SerializeField]
	private OWRenderer[] _characterRenderers = new OWRenderer[0];
	[Space]
	[ColorUsage(false, true)]
	[SerializeField]
	private Color _skyLightColor = new Color(0.36f, 0.49f, 0.71f, 1f);
	[SerializeField]
	private Vector3 _skyLightDir = new Vector3(-1f, 2f, -1f);
	[ColorUsage(false, true)]
	[SerializeField]
	private Color _bounceLightColor = new Color(0.71f, 0.52f, 0.36f, 1f);
	[SerializeField]
	private Vector3 _bounceLightDir = new Vector3(0f, -2f, 1f);
	[ColorUsage(false, true)]
	[SerializeField]
	private Color _rimLightColor = new Color(0.83f, 0.81f, 0.57f, 1f);
	[SerializeField]
	private Vector3 _rimLightDir = new Vector3(1f, 0f, -1f);
	[Space]
	[SerializeField]
	private Vector3 _falloffCenter = new Vector3(0f, 2f, 0f);
	[SerializeField]
	private float _falloffRadius = 1f;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Gizmos.color = Color.blue;
			Gizmos.DrawLine(Vector3.zero, _skyLightDir);
			Gizmos.color = Color.red;
			Gizmos.DrawLine(Vector3.zero, _bounceLightDir);
			Gizmos.color = Color.green;
			Gizmos.DrawLine(Vector3.zero, _rimLightDir);
			Gizmos.color = Color.yellow;
			Gizmos.DrawWireSphere(_falloffCenter, _falloffRadius);
		}
	}
}
