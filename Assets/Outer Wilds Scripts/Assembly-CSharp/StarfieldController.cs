using UnityEngine;
using System;
using Starfield;

public class StarfieldController : MonoBehaviour
{
	[Serializable]
	private struct StarLookup
	{
		public StarLookup(int groupIndex, int starIndex) : this()
		{
		}

		public int groupIndex;
		public int starIndex;
	}

	[SerializeField]
	private StarfieldData _starfieldData;
	[SerializeField]
	private Renderer _starfieldRenderer;
	[SerializeField]
	private GameObject _supernovaPrefab;
	[Space]
	[SerializeField]
	private GameObject _eyeSupernovaPrefab;
	[SerializeField]
	private Transform _eyeSupernovaSpawnPos;
	[Space]
	[SerializeField]
	private Renderer _dreamStarfieldRenderer;
	[SerializeField]
	[HideInInspector]
	private StarLookup[] _orderedStarIndices;
}
