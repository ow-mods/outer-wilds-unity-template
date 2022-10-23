using System;
using UnityEngine;

[Serializable]
public class AudioLibrary : ScriptableObject
{
	[Serializable]
	public struct AudioEntry
	{
		public AudioType type;
		public AudioClip[] clips;
		public float volume;

		public AudioEntry(AudioType t, AudioClip[] c)
		{
			type = t;
			clips = c;
			volume = 1f;
		}

		public AudioEntry(AudioType t, AudioClip[] c, float v)
		{
			type = t;
			clips = c;
			volume = v;
		}
	}

	public AudioEntry[] audioEntries;
}
