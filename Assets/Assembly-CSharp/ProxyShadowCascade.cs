using System;

public static class ProxyShadowCascade
{
	[Flags]
	public enum Flags
	{
		Near = 1,
		Mid = 2,
		Far = 4,
		Final = 8
	}

	[Serializable]
	public struct Division
	{
		public Flags shadowGroup;

		public float fraction;

		public Division(Flags cascadeShadowGroup, float cascadeFraction)
		{
			shadowGroup = cascadeShadowGroup;
			fraction = cascadeFraction;
		}
	}
}
