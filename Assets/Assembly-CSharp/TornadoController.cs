using UnityEngine;

public class TornadoController : SectoredMonoBehaviour
{
	[SerializeField]
	private OWTriggerVolume _underwaterVolume;
	[Space]
	[SerializeField]
	private bool _snapBonesToSphere = true;
	[SerializeField]
	private bool _wander;
	[SerializeField]
	private float _wanderRate = 0.02f;
	[SerializeField]
	private float _wanderDegreesX = 45f;
	[SerializeField]
	private float _wanderDegreesZ = 20f;
	[Space]
	[SerializeField]
	private bool _startActive = true;
	[SerializeField]
	private GameObject _tornadoRoot;
	[SerializeField]
	private FluidVolume[] _fluids;
	[SerializeField]
	private OWTriggerVolume _collapseTrigger;
	[SerializeField]
	private OWAudioSource _audioSource;
	[Space]
	[SerializeField]
	private Transform _topBone;
	[SerializeField]
	private Transform _midBone;
	[SerializeField]
	private Transform _bottomBone;
	[SerializeField]
	private Renderer[] _topBlendRenderers;
	[SerializeField]
	private Renderer[] _bodyRenderers;
	[SerializeField]
	private Renderer[] _bottomBlendRenderers;
	[Space]
	[SerializeField]
	private float _topFadeTime = 0.3f;
	[SerializeField]
	private float _bodyFadeTime = 1f;
	[SerializeField]
	private float _bottomFadeTime = 0.3f;
	[Space]
	[SerializeField]
	private float _topScaleAmplitude = 0.3f;
	[SerializeField]
	private float _topScaleFrequency = 0.1f;
	[SerializeField]
	private float _midScaleAmplitude = 0.3f;
	[SerializeField]
	private float _midScaleFrequency = 0.1f;
	[SerializeField]
	private float _bottomScaleAmplitude = 0.3f;
	[SerializeField]
	private float _bottomScaleFrequency = 0.1f;
	[Space]
	[SerializeField]
	private float _rotationSpeed = 45f;
	[SerializeField]
	private float _midRotationAmplitude = 20f;
	[SerializeField]
	private Vector2 _midRotationXZFrequency = new Vector2(0.1f, 0.15f);
}
