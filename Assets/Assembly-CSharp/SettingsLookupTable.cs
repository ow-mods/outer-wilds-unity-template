using UnityEngine;
using System;

public class SettingsLookupTable : ScriptableObject
{
	[Serializable]
	public struct SettingsEntry
	{
		public SettingsID settingsId;
		public RebindableID rebindableId;
		public UITextType labelTextType;
		public UITextType tooltipTextType;

		public SettingsEntry(SettingsID sId, UITextType label, UITextType tooltip)
			: this(sId, RebindableID.UNDEFINED, label, tooltip)
		{
		}

		public SettingsEntry(SettingsID sId, RebindableID rId, UITextType label, UITextType tooltip)
		{
			settingsId = sId;
			rebindableId = rId;
			labelTextType = label;
			tooltipTextType = tooltip;
		}
	}

	public SettingsEntry[] settingsEntries;
}
