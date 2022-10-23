using UnityEngine;
using UnityEngine.UI;

public class LoadManager : MonoBehaviour
{
	public enum FadeType
	{
		None,
		ToBlack,
		ToWhite
	}

	[SerializeField]
	private Canvas _fadeCanvas;
	[SerializeField]
	private Image _fadeImage;
}
