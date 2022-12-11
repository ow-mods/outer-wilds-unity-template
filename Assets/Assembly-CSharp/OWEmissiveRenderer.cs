using UnityEngine;

public class OWEmissiveRenderer : OWRenderer
{
	[SerializeField]
	private int _emissiveMaterialIndex;
	[Header("HDR Color Space Hack")]
	[SerializeField]
	private bool _convertToGamma;
}
