using UnityEngine;

public class SlideCollectionContainer : MonoBehaviour
{
	[SerializeField]
	private string _shipLogOnComplete;
	[SerializeField]
	private string[] _playWithShipLogFacts;
	[SerializeField]
	private bool _autoLoadStreaming;
	[SerializeField]
	private bool _invertBlackFrames;
	[SerializeField]
	private SlideCollection _slideCollection = new SlideCollection(0);
}
