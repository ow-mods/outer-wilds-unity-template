using System;
using UnityEngine;

public class CubeLight : SectoredMonoBehaviour
{
	[Serializable]
	private struct FaceSuperGroup
	{
		public ProxyShadowCasterSuperGroup[] superGroups;
	}

	public bool debugShadowMap;
	public int renderMask;
	[SerializeField]
	private FaceSuperGroup[] _faceSuperGroups;
	[SerializeField]
	private int _neverDrawMask;
	[SerializeField]
	private int _neverDynamicMask;
	[SerializeField]
	private bool _updateFrustums;
	[SerializeField]
	private bool _cameraTest = true;
	[SerializeField]
	private int _renderTextureSize = 1024;
	[SerializeField]
	private float _cascadeBlendRange = 50f;
	[SerializeField]
	private float _range = 50000f;
	[SerializeField]
	private float _receiverPlaneDepthBias;
	[SerializeField]
	private float _distanceBias = 0.985f;
	[SerializeField]
	private float _padOffset = 0.0108f;
	[SerializeField]
	private float _padExponent = 500f;
	[SerializeField]
	private Light _light;
	[SerializeField]
	private RingworldShadowsOverride _ringworldShadowsOverride;
	[SerializeField]
	private int _debugFrustumDraw;
}
