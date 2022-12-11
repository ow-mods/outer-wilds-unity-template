using UnityEngine;

public abstract class RaftCarrier : MonoBehaviour
{
	[SerializeField]
	protected OWTriggerVolume _trigger;
	[SerializeField]
	protected Transform _craneChains;
	[SerializeField]
	protected Transform _craneHookRoot;
	[SerializeField]
	protected float _craneHookChainOffset;
	[SerializeField]
	protected float _hookStartLocalY;
	[SerializeField]
	protected float _raftAlignSpeed = 4f;
	[SerializeField]
	protected float _liftingDelay = 0.25f;
	[SerializeField]
	protected Vector2 _chainTilingModifier;
	[SerializeField]
	protected OWAudioSource _oneShotAudio;
	[SerializeField]
	protected OWAudioSource _loopingAudio;
	[SerializeField]
	protected Animator _hooksAnimator;
}
