using UnityEngine;

public class RiverFlowMarker : MonoBehaviour
{
	public float magnitude;
	[HideInInspector]
	public float test;
	[HideInInspector]
	public bool postFlood;

	private void OnValidate()
	{
		if (magnitude < 0f)
		{
			magnitude = 0f;
		}
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = (postFlood ? Color.cyan : Color.red);
		Gizmos.DrawSphere(base.transform.position, 2f);
	}

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			DrawHighlightMarker();
			RiverFlowMarker[] componentsInChildren = base.transform.parent.gameObject.GetComponentsInChildren<RiverFlowMarker>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].DrawLine();
				if (!Application.isPlaying)
				{
					componentsInChildren[i].test = 0f;
				}
			}
		}
		else
		{
			DrawLine();
		}
	}

	public void DrawHighlightMarker()
	{
		Matrix4x4 matrix = Gizmos.matrix;
		Gizmos.matrix = matrix * Matrix4x4.TRS(base.transform.position, base.gameObject.transform.rotation, Vector3.one);
		Gizmos.color = Color.yellow;
		Gizmos.DrawSphere(Vector3.zero, 2f);
		Gizmos.matrix = matrix;
	}


	public void DrawLine()
	{
		Matrix4x4 matrix = Gizmos.matrix;
		Gizmos.matrix = matrix * Matrix4x4.TRS(base.transform.position, base.transform.rotation, Vector3.one);
		Gizmos.color = (postFlood ? Color.cyan : Color.red);
		Vector3 vector = Vector3.up * 0.5f + Vector3.forward * 2f;
		Gizmos.DrawLine(vector, vector + Vector3.forward * magnitude * 2f);
		if (test > 0f)
		{
			Gizmos.color = Color.white;
			Gizmos.DrawWireSphere(Vector3.zero, 2f + test * 10f);
		}
		Gizmos.matrix = matrix;
	}
}
