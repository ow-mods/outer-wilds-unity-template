using System;
using System.Runtime.Serialization;
using UnityEngine;

[Serializable]
public class SettingsSave
{
	[Serializable]
	public struct UserDeviceInfo
	{
		public bool userEnabled;
		public string unityDeviceName;
		public int productId;
		public int vendorId;
		public string manufacturer;
		public string productName;
	}

	public bool autoBoost;
	public bool autoRun = true;
	public bool autoEquipTranslator = true;
	public TextSpeed textSpeed = TextSpeed.Normal;
	public bool freezeTimeWhileReading = true;
	public bool showShipLogNotifications = true;
	public bool detectiveModeEnabled = true;
	public int inversionFactor = 1;
	public int lookSensitivity = 5;
	public int flightSensitivity = 5;
	[OptionalField(VersionAdded = 2)]
	public Difficulty difficulty = Difficulty.NORMAL;
	[OptionalField(VersionAdded = 2)]
	public bool autopilotEnabled = true;
	[OptionalField(VersionAdded = 2)]
	public bool buttonPromptsEnabled = true;
	[OptionalField(VersionAdded = 7)]
	public bool reducedFrights;
	[OptionalField(VersionAdded = 2)]
	public int shipInversionFactor = 1;
	[OptionalField(VersionAdded = 6)]
	public bool rumbleEnabled = true;
	[OptionalField(VersionAdded = 8)]
	public ButtonPromptImgSet promptImgSet = ButtonPromptImgSet.DEFAULT;
	[OptionalField(VersionAdded = 9)]
	public UserDeviceInfo[] deviceEnabledList;
	[OptionalField(VersionAdded = 3)]
	public TextTranslation.Language language;
	[OptionalField(VersionAdded = 4)]
	public bool freezeTimeWhileReadingShipLog = true;
	[OptionalField(VersionAdded = 4)]
	public bool freezeTimeWhileReadingConversations;
	[OptionalField(VersionAdded = 2)]
	public float innerDeadZone = 0.5f;
	[OptionalField(VersionAdded = 2)]
	public float outerDeadZone = 0.5f;
	[OptionalField(VersionAdded = 2)]
	public float masterVolume = 1f;
	[OptionalField(VersionAdded = 5)]
	public float musicVolume = 1f;
	[OptionalField(VersionAdded = 7)]
	public float sfxVolume = 1f;
}
