using System;
using UnityEngine;
using System.Collections.Generic;

[Serializable]
[PreferBinarySerialization]
public class SceneMeshData : ScriptableObject
{
	[SerializeField]
	public List<Mesh> data;
}
