using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class GameSave
{
	public int loopCount = 1;
	public bool[] knownFrequencies = new bool[7] { true, true, false, false, false, false, false };
	public List<string> newlyRevealedFactIDs;
	public DeathType lastDeathType;
	[OptionalField(VersionAdded = 2)]
	public int burnedMarshmallowEaten;
	[OptionalField(VersionAdded = 3)]
	public uint fullTimeloops;
	[OptionalField(VersionAdded = 3)]
	public uint perfectMarshmallowsEaten;
	[OptionalField(VersionAdded = 4)]
	public bool warpedToTheEye;
	[OptionalField(VersionAdded = 4)]
	public float secondsRemainingOnWarp;
	[OptionalField(VersionAdded = 5)]
	public int loopCountOnParadox;
	[OptionalField(VersionAdded = 6)]
	public StartupPopups shownPopups;
	[OptionalField(VersionAdded = 6)]
	public string version;
	[OptionalField(VersionAdded = 7)]
	public bool ps5Activity_canResumeExpedition;
	[OptionalField(VersionAdded = 7)]
	public List<string> ps5Activity_availableShipLogCards;
	[OptionalField(VersionAdded = 7)]
	[FormerlySerializedAs("runInitGammaSetting")]
	public bool didRunInitGammaSetting;
}
