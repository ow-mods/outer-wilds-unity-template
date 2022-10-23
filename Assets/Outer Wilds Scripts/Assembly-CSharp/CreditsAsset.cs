using UnityEngine;

[CreateAssetMenu]
public class CreditsAsset : ScriptableObject
{
	public TextAsset xml;
	public GameObject fadeSectionTemplate;
	public GameObject scrollSectionTemplate;
	public GameObject lineSpacerTemplate;
	[SerializeField]
	[HideInInspector]
	private TemplateDictionary _templates;
	[SerializeField]
	[HideInInspector]
	private string _xmlText;
}
