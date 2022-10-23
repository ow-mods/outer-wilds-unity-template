using System;

[Serializable]
public class InputRebindableData
{
	public struct ValidationResult
	{
		public bool notifyPlayerOfChanges;
		public int previousVersion;
	}

	public InputRebindableData(bool init = false)
	{
	}

	public InputRebindableData(InputRebindable[] list) : this()
	{
		rebindableList = list;
	}

	public int version = 4;
	public InputRebindable[] rebindableList;
	public InputUtil.GamePadPresetConfig gamepadConfig = InputUtil.GamePadPresetConfig.NONE;
	public InputUtil.ButtonPromptPresetConfig promptConfig = InputUtil.ButtonPromptPresetConfig.NONE;
	public string lastUsedDeviceName = "";
	public int lastUsedDeviceIndex = -1;
}
