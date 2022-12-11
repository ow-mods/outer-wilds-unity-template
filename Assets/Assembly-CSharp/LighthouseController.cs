using UnityEngine;

public class LighthouseController : MonoBehaviour
{
	[SerializeField]
	private BuildingRailController _stageOneController;
	[SerializeField]
	private BuildingRailController _stageTwoController;
	[SerializeField]
	private BuildingRailController _mapHouseStageTwoController;
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
	[Header("Floor Damage")]
	[SerializeField]
	private CustomCollisionChecker _floorCollisionChecker;
	[SerializeField]
	private GameObject _floorIntact;
	[SerializeField]
	private GameObject _floorDamaged;
	[Header("Audio")]
	[SerializeField]
	private OWAudioSource _collapseAudio;
	[SerializeField]
	private OWAudioSource _splashAudio;
	[Header("Secret Passage")]
	[SerializeField]
	private OWLightController[] _muralRoomLights;
	[SerializeField]
	private int[] _doorLightIndices;
	[SerializeField]
	private AbstractDoor _secretDoor;
}
