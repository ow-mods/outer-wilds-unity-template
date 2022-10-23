using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "DetailPalette", menuName = "Detail Palette", order = 650)]
public class DetailPalette : ScriptableObject
{
	public DetailPrototype[] detailPrototypes = new DetailPrototype[0];
}
