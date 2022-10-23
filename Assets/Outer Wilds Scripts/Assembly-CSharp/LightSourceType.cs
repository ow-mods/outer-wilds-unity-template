using System;

[Flags]
public enum LightSourceType
{
	UNDEFINED = 0,
	FLASHLIGHT = 1,
	PROBE = 2,
	DREAM_LANTERN = 4,
	SIMPLE_LANTERN = 8,
	VOLUME_ONLY = 16
}
