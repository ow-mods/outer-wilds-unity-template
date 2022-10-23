using System;

[Flags]
public enum ItemType
{
	Invalid = 0,
	Scroll = 1,
	WarpCore = 2,
	SharedStone = 4,
	ConversationStone = 8,
	Lantern = 16,
	SlideReel = 32,
	DreamLantern = 64,
	VisionTorch = 128
}