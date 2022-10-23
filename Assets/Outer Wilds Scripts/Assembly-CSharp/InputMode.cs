using System;

[Flags]
public enum InputMode
{
	All = 0,
	Character = 1,
	Roasting = 2,
	Dialogue = 4,
	ShipComputer = 8,
	Map = 0x10,
	ScopeZoom = 0x20,
	Menu = 0x40,
	ShipCockpit = 0x80,
	LandingCam = 0x100,
	ModelShip = 0x200,
	SatelliteCam = 0x400,
	StationaryProbeLauncher = 0x800,
	NomaiRemoteCam = 0x1000,
	PatchingSuit = 0x2000,
	Rebinding = 0x4000,
	KeyboardInput = 0x8000,
	None = 0x10000
}
