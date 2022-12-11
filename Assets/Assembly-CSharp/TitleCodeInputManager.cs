using System;
using System.Collections.Generic;
using UnityEngine;

public class TitleCodeInputManager : MonoBehaviour
{
	[Flags]
	public enum CommandSequenceIds
	{
		NONE = 0,
		KON_CODE = 1,
		INPUT_RESET = 2
	}
}