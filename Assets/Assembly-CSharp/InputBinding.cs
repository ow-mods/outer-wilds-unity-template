using System;
using System.Runtime.Serialization;
using UnityEngine;

[Serializable]
[Obsolete("Use InputCommands/InputAction instead", false)]
public class InputBinding
{
	public KeyCode positiveKey;
	public KeyCode negativeKey;
	public string unityJoystickAxisName;
	public AxisIdentifier axisID;
	public int displayDirection;
	[OptionalField(VersionAdded = 3)]
	public int axisDirection;
	[OptionalField(VersionAdded = 3)]
	public JoystickButton gamepadButtonPos;
	[OptionalField(VersionAdded = 3)]
	public JoystickButton gamepadButtonNeg;
}
