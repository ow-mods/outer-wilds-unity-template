using System;
using UnityEngine;

[Serializable]
public class BuoyancyData
{
	public float density = 1f;
	public float boundingRadius;
	public AnimationCurve submergeCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
	public AnimationCurve dragCurve = AnimationCurve.Linear(0f, 1f, 1f, 1f);
	public bool checkAgainstWaves;
}
