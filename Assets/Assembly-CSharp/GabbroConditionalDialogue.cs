using System;
using UnityEngine;

[Serializable]
public class GabbroConditionalDialogue
{
	public bool hasTalkedToGabbro;
	public bool hasMergeTriggered;
	public int minLoopCount = 1;
	public TextAsset dialogueTextAsset;
	public bool triggerMerge;
}
