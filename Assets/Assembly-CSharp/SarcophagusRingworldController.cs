using UnityEngine;

public class SarcophagusRingworldController : MonoBehaviour
{
	[SerializeField]
	private Transform _leftDoor;
	[SerializeField]
	private Transform _rightDoor;
	[SerializeField]
	private float _doorOpenDistance = 0.5f;
	[Space]
	[SerializeField]
	private OWRenderer[] _firstSealLockedVisuals = new OWRenderer[0];
	[SerializeField]
	private OWLight2[] _firstSealLockedLights = new OWLight2[0];
	[SerializeField]
	private OWRenderer[] _firstSealUnlockedVisuals = new OWRenderer[0];
	[SerializeField]
	private OWRenderer[] _secondSealLockedVisuals = new OWRenderer[0];
	[SerializeField]
	private OWLight2[] _secondSealLockedLights = new OWLight2[0];
	[SerializeField]
	private OWRenderer[] _secondSealUnlockedVisuals = new OWRenderer[0];
	[SerializeField]
	private OWRenderer[] _thirdSealLockedVisuals = new OWRenderer[0];
	[SerializeField]
	private OWLight2[] _thirdSealLockedLights = new OWLight2[0];
	[SerializeField]
	private OWRenderer[] _thirdSealUnlockedVisuals = new OWRenderer[0];
	[Space]
	[SerializeField]
	private OWRenderer[] _lanternFlameVisuals = new OWRenderer[0];
	[SerializeField]
	private OWLight2[] _lanternFlameLights = new OWLight2[0];
}