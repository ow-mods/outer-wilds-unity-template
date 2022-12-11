using System;
using UnityEngine;

[Serializable]
public class VisionSlide
{
	public GameObject[] activeObjects;
	public Vector3 localPosition;
	public Vector3 localEulerAngles;
	public float cameraTilt;
	public float cameraFOV = 70f;

	public void SetActive(bool active)
	{
		for (int i = 0; i < activeObjects.Length; i++)
		{
			activeObjects[i].SetActive(active);
		}
	}
}