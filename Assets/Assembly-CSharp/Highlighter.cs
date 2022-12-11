using UnityEngine;

public class Highlighter : MonoBehaviour
{
	public Color color = Color.red;
	public bool thisObjectOnly;

	private void OnDrawGizmos()
	{
		Gizmos.color = color;
		if (thisObjectOnly)
		{
			HighlightMesh(base.transform);
		}
		else
		{
			HighlightMeshRecursive(base.transform);
		}
	}

	private static void HighlightMesh(Transform transform)
	{
		MeshRenderer component = transform.GetComponent<MeshRenderer>();
		if (component != null)
		{
			MeshFilter component2 = transform.GetComponent<MeshFilter>();
			if (component2 != null && component2.sharedMesh != null)
			{
				Gizmos.matrix = component.localToWorldMatrix;
				Gizmos.DrawMesh(component2.sharedMesh);
			}
		}
	}

	private static void HighlightMeshRecursive(Transform transform)
	{
		HighlightMesh(transform);
		foreach (Transform item in transform)
		{
			HighlightMeshRecursive(item);
		}
	}
}
