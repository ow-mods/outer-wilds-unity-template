using System;

namespace Starfield
{
	[Serializable]
	public class StarGroup
	{
		public StarInstance[] stars = new StarInstance[0];
		public string name = "StarGroup";
		public bool hidden;
	}
}
