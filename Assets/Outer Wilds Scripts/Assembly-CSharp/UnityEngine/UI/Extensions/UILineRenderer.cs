using UnityEngine.UI;
using UnityEngine;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Primitives/UILineRenderer")]
	public class UILineRenderer : MaskableGraphic
	{
		[SerializeField]
		private Texture m_Texture;
		[SerializeField]
		private Rect m_UVRect = new Rect(0f, 0f, 1f, 1f);
		public bool UseCapPoints;
		public float LineThickness = 2f;
		public bool UseMargins;
		public Vector2 Margin;
		public Vector2[] Points;
		public bool relativeSize;
	}
}
