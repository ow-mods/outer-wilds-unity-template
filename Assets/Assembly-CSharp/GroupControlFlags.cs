using System;

[Flags]
public enum GroupControlFlags
{
	None = 0,
	Renderers = 1,
	Colliders = 2,
	Lights = 4
}