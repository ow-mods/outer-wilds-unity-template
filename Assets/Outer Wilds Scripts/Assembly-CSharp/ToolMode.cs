using System;

[Flags]
public enum ToolMode
{
	None = 0,
	Probe = 1,
	SignalScope = 2,
	Translator = 4,
	Item = 8
}
