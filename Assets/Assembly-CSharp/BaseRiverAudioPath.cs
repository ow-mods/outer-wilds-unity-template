using UnityEngine;
using UnityEngine.Serialization;
using System;

public abstract class BaseRiverAudioPath : MonoBehaviour
{
	[Serializable]
	protected struct VertexPair
	{
		public Vector3 v0;
		public Vector3 v1;
	}

	[Serializable]
	public struct Triangle
	{
		public Vector3 v0;
		public Vector3 v1;
		public Vector3 v2;
		public Vector3 centroid;
		public Vector3 normal;
		public float cachedDegree;
		public byte allowedEdgeFlags;
		public short[] adjacency;

		public Triangle(Vector3 p0, Vector3 p1, Vector3 p2)
		{
			v0 = p0;
			v1 = p1;
			v2 = p2;
			centroid = (v0 + v1 + v2) / 3f;
			normal = Vector3.Cross(v1 - v0, v2 - v0).normalized;
			cachedDegree = 0f;
			allowedEdgeFlags = 0;
			adjacency = new short[3] { -1, -1, -1 };
		}
	}

	[Tooltip("Roots of meshes to take into account as terrain go here")]
	[SerializeField]
	protected Transform[] _includedMeshRoots = new Transform[0];
	[Tooltip("Meshes that are children of the above root but are to be excluded")]
	[SerializeField]
	protected Transform[] _meshExceptions = new Transform[0];
	[SerializeField]
	protected int sampledTrianglesCount = 40;
	[SerializeField]
	protected float minY;
	[SerializeField]
	protected float maxY;
	[SerializeField]
	protected bool _loop = true;
	[SerializeField]
	protected Mesh _meshToImport;
	[HideInInspector]
	[SerializeField]
	protected VertexPair[] voronoiLines = new VertexPair[0];
	[FormerlySerializedAs("_preFloodTriangles")]
	[HideInInspector]
	[SerializeField]
	protected Triangle[] _baseFloodTriangles = new Triangle[0];
	[FormerlySerializedAs("_cachedPreFloodDegreeSections")]
	[HideInInspector]
	[SerializeField]
	protected float[] _cachedTriangleSections = new float[0];
	[HideInInspector]
	[SerializeField]
	protected bool _importedMesh;
	[Space]
	[Header("Editor Tools")]
	public bool showVoronoi;
	public bool showPostFlood;
	[SerializeField]
	private bool _showCentroidLabels = true;
	[SerializeField]
	private bool _showAdjacency;

	protected void DrawPath(Triangle[] toShow)
	{
		if (voronoiLines != null && showVoronoi)
		{
			Gizmos.color = new Color(1f, 0.647f, 0f);
			VertexPair[] array = voronoiLines;
			for (int i = 0; i < array.Length; i++)
			{
				VertexPair vertexPair = array[i];
				Gizmos.DrawLine(vertexPair.v0, vertexPair.v1);
			}
		}
		if (toShow != null)
		{
			int num = 0;
			for (int i = 0; i < toShow.Length; i++)
			{
				Triangle triangle = toShow[i];
				Vector3 vector = base.transform.TransformPoint(triangle.v0);
				Vector3 vector2 = base.transform.TransformPoint(triangle.v1);
				Vector3 vector3 = base.transform.TransformPoint(triangle.v2);
				Gizmos.color = Color.HSVToRGB((float)num / (float)toShow.Length, 1f, 1f);
				Gizmos.DrawWireSphere(vector, 1f);
				Gizmos.DrawWireSphere(vector2, 1f);
				Gizmos.DrawWireSphere(vector3, 1f);
				Gizmos.color = (((triangle.allowedEdgeFlags & 1) > 0) ? Color.cyan : Color.red);
				Gizmos.DrawLine(vector, vector2);
				Gizmos.color = (((triangle.allowedEdgeFlags & 2) > 0) ? Color.cyan : Color.red);
				Gizmos.DrawLine(vector2, vector3);
				Gizmos.color = (((triangle.allowedEdgeFlags & 4) > 0) ? Color.cyan : Color.red);
				Gizmos.DrawLine(vector3, vector);
				Gizmos.color = new Color(1f, 0.647f, 0f);
				Vector3 vector4 = base.transform.TransformPoint(triangle.centroid);
				Gizmos.DrawWireSphere(vector4, 1f);
				Gizmos.DrawLine(vector4, vector4 + base.transform.TransformDirection(triangle.normal) * 5f);
				num++;
			}
		}
	}
}
