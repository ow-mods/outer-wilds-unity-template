using UnityEngine;

public class GhostNodeMarker : MonoBehaviour
{
	[HideInInspector]
	public int nodeIndex = -1;
	[HideInInspector]
	public GhostNodeMarker[] visibleNodes = new GhostNodeMarker[0];
	public bool isPathNode;
	public bool pathStart;
	public bool pathEnd;
	[Space]
	public bool isPatrolNode;
	[Space]
	public bool isSearchNode;
	[EnumFlags]
	public GhostNode.NodeLayer searchLayer = (GhostNode.NodeLayer)(-1);
	public float searchAngle = 360f;
	private void OnDrawGizmos()
	{
		if (Application.isPlaying) return;

		if (isPathNode) Gizmos.color = Color.blue;
		else if (isPatrolNode) Gizmos.color = Color.magenta;
		else if (isSearchNode) Gizmos.color = Color.yellow;
		else Gizmos.color = Color.red;

		Gizmos.DrawSphere(base.transform.position, 0.5f);
		if (isSearchNode)
		{
			Vector3 vector = new Vector3(0f, 0.75f, 0f);
			if ((searchLayer & GhostNode.NodeLayer.Red) != 0)
			{
				Gizmos.color = Color.red;
				Gizmos.DrawSphere(base.transform.position + vector, 0.25f);
				vector.y += 0.5f;
			}
			if ((searchLayer & GhostNode.NodeLayer.Yellow) != 0)
			{
				Gizmos.color = Color.yellow;
				Gizmos.DrawSphere(base.transform.position + vector, 0.25f);
				vector.y += 0.5f;
			}
			if ((searchLayer & GhostNode.NodeLayer.Blue) != 0)
			{
				Gizmos.color = Color.blue;
				Gizmos.DrawSphere(base.transform.position + vector, 0.25f);
				vector.y += 0.5f;
			}
			if ((searchLayer & GhostNode.NodeLayer.Orange) != 0)
			{
				Gizmos.color = new Color(0.993f, 0.463f, 0.11f);
				Gizmos.DrawSphere(base.transform.position + vector, 0.25f);
				vector.y += 0.5f;
			}
			if ((searchLayer & GhostNode.NodeLayer.Green) != 0)
			{
				Gizmos.color = Color.green;
				Gizmos.DrawSphere(base.transform.position + vector, 0.25f);
				vector.y += 0.5f;
			}
			if ((searchLayer & GhostNode.NodeLayer.Purple) != 0)
			{
				Gizmos.color = Color.magenta;
				Gizmos.DrawSphere(base.transform.position + vector, 0.25f);
				vector.y += 0.5f;
			}
		}
		
		if (!OWGizmos.IsDirectlySelected(base.gameObject)) return;
		Gizmos.color = new Color(1f, 1f, 1f, 0.5f);
		for (int i = 0; i < visibleNodes.Length; i++)
		{
			if (visibleNodes[i] != null)
			{
				Gizmos.DrawLine(base.transform.position + new Vector3(0f, 3f, 0f), visibleNodes[i].transform.position + new Vector3(0f, 1.8f, 0f));
			}
		}
	}
}
