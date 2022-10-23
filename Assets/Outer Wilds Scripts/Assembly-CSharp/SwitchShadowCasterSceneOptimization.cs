using UnityEngine;

public class SwitchShadowCasterSceneOptimization : MonoBehaviour
{
	public bool skip;
	[Header("Indiscriminate Shadow Disabling")]
	public bool disableAllShadowCasting;
	[Header("Disable if Dimensions are Below:")]
	public Vector3 minBoundsSize = new Vector3(0.5f, 0.5f, 0.5f);
	public float minBoundsVolume = 0.125f;
	[Header("Disable if GO Name Contains:")]
	public string[] nameSearchStrings = new string[0];
	[Header("Disable if Shader Name Contains:")]
	public string[] shaderSearchStrings = new string[0];
	[Header("Additional Options")]
	public bool disableProbeBlending = true;
	public bool disableLightProbes = true;
	public bool disableParticleShadows = true;
	[Header("Exceptions (Keep Shadows on These)")]
	public GameObject[] exceptions = new GameObject[0];
}
