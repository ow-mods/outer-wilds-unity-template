using System;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
[PreferBinarySerialization]
public class BakedTerrainMesh : ScriptableObject
{
	[HideInInspector]
	[FormerlySerializedAs("mesh")]
	public Mesh _mesh;
	[HideInInspector]
	public Mesh colliderMesh;
}
