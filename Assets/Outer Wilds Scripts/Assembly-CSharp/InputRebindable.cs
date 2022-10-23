using System;

[Serializable]
[Obsolete("Use InputCommands/InputAction instead", false)]
public class InputRebindable
{
	public enum InputType
	{
		UNDEFINED = 0,
		BUTTON = 1,
		BINARY_AXIS = 2,
		ANALOG_AXIS = 3,
		ANALOG_AXIS_ZERO_TO_ONE = 4,
	}

	public enum AxisDirection
	{
		UNDEFINED = 0,
		HORIZONTAL = 1,
		VERTICAL = 2,
	}

	public enum BindingCategory
	{
		UNDEFINED,
		GAMEPAD,
		KEYBD_MOUSE
	}

	public InputRebindable(RebindableID id, InputType inputType, AxisDirection direction = AxisDirection.UNDEFINED)
	{
	}

	public InputRebindable(UITextType labelType, InputType inputType, AxisDirection direction = AxisDirection.UNDEFINED)
	{
	}
}
