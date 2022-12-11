using System;
using UnityEngine;

public class FogLight : MonoBehaviour
{
	[Serializable]
	public class LightData
	{
		public Vector3 screenPos;
		public float scale;
		public float alpha;
		public float maxAlpha;
		public Color color;
	}

	[SerializeField]
	private Texture2D _lightIcon;
	[SerializeField]
	private Color _tint = Color.white;
	[SerializeField]
	private float _occlusionRange = 200f;
	[SerializeField]
	private float _minVisibleDistance;
	[SerializeField]
	private float _maxVisibleDistance = float.PositiveInfinity;
	[SerializeField]
	private float _maxAlpha = 0.5f;
}
