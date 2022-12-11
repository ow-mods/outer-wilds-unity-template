using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class Detector : MonoBehaviour
{
	[Flags]
	public enum Name
	{
		Unnamed = 0,
		Player = 1,
		PlayerCamera = 2,
		Probe = 4,
		Ship = 8,
		Raft = 16
	}
}
