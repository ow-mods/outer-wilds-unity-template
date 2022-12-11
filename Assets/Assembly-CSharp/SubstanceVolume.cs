using UnityEngine;

[RequireComponent(typeof(Collider))]
public class SubstanceVolume : MonoBehaviour
{
	public enum SubstanceType
	{
		Oxygen = 0,
	}

	[SerializeField]
	private SubstanceType _substanceType;
}
