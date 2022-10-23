using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "BRDFRegistry", menuName = "BRDF Registry", order = 650)]
public class BRDFRegistry : ScriptableObject
{
	public Color[] brdfSpecColors = new Color[8];
	public Texture2D[] brdfLookups = new Texture2D[8];
	public Texture2DArray brdfLookupArray;
	
	public enum BRDFLookupID
	{
		Geode,
		GravityCrystal,
		NomaiGlass,
		Ice,
		DarkMatter,
		Unused6,
		StrangerGlass,
		Unused8
	}
}
