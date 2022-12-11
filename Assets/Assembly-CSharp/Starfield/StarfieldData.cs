using System;
using UnityEngine;

namespace Starfield
{
	[Serializable]
	[CreateAssetMenu(fileName = "StarfieldData", menuName = "Starfield Data", order = 650)]
	public class StarfieldData : ScriptableObject
	{
		public StarGroup[] starGroups;
	}
}
