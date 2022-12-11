using UnityEngine;

public class TessellatedSphereLOD : MonoBehaviour
{
	[SerializeField]
	public float _highAltitude = 50f;
	[SerializeField]
	public Material[] _highAltitudeMaterials = new Material[0];
	[SerializeField]
	public float _lowAltitude = -50f;
	[SerializeField]
	public Material[] _lowAltitudeMaterials = new Material[0];
	[SerializeField]
	public int _lowAltitudeMaxLOD;
}
