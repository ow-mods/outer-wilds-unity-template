using UnityEngine;

public class Marshmallow : MonoBehaviour
{
	public enum MallowState
	{
		Default,
		Burning,
		Shriveling,
		Gone
	}

	[SerializeField]
	private MeshRenderer _fireRenderer;
	[SerializeField]
	private ParticleSystem _smokeParticles;
	[SerializeField]
	private MeshRenderer _mallowRenderer;
	[SerializeField]
	private Color _rawColor;
	[SerializeField]
	private Color _toastedColor;
	[SerializeField]
	private Color _burntColor;
}
