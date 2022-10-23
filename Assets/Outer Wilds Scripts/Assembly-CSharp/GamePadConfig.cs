using System;

[Serializable]
public class GamePadConfig
{
	public GamePadConfig(InputUtil.GamePadPresetConfig configType = InputUtil.GamePadPresetConfig.NONE)
	{
		buttonPromptType = InputUtil.ButtonPromptPresetConfig.NONE;
	}

	public string gamepadHardwareName;
	public InputUtil.GamePadPresetConfig originalPreset;
	public InputUtil.ButtonPromptPresetConfig buttonPromptType;
}
