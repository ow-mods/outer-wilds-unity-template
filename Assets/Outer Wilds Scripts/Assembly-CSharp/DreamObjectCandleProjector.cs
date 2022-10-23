using UnityEngine;

public class DreamObjectCandleProjector : MonoBehaviour
{
	[SerializeField]
	private DreamObjectProjection[] _projections = new DreamObjectProjection[0];
	[Space]
	[SerializeField]
	private DreamCandle[] _controllingCandles = new DreamCandle[0];
	[SerializeField]
	private DreamCandle[] _controllingCandlesBack = new DreamCandle[0];
	[SerializeField]
	private OWTriggerVolume _blockingVolume;
}