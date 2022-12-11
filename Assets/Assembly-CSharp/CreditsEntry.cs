using UnityEngine;
using UnityEngine.UI;

public class CreditsEntry : MonoBehaviour
{
	public enum Style
	{
		Content,
		Header,
		Title
	}
	
	[SerializeField]
	private Text[] _columns;
	[SerializeField]
	private float _topMargin;
	[SerializeField]
	private float _bottomMargin;
}
