using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections.Generic;

public class FontAndLanguageController : MonoBehaviour
{
	[Serializable]
	protected class TextItemsRootObject
	{
		public GameObject rootObj;
		public GameObject[] excludeObj;
		public bool controlScale;
		public bool useDefaultLineSpacing = true;
		public bool isLanguageFont;
	}

	[Serializable]
	protected class TextItem
	{
		public Text textElement;
		public bool controlScale;
		public bool useDefaultLineSpacing = true;
		public bool isLanguageFont;
	}

	[Serializable]
	protected struct TextContainer
	{
		public Text textElement;
		public bool shouldScale;
		public bool useDefaultLineSpacing;
		public bool isLanguageFont;
		public Font originalFont;
		public float originalSpacing;
		public int originalFontSize;
		public Vector3 originalScale;
		public bool markForRemoval;
	}

	[SerializeField]
	protected List<FontAndLanguageController.TextItemsRootObject> _rootObjectsWithTextList;
	[SerializeField]
	protected List<FontAndLanguageController.TextItem> _textItemList;
}
