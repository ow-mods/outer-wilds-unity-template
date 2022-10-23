using UnityEngine;

[RequireComponent(typeof(OWLight2))]
public class ProbeSpotlight : MonoBehaviour
{
	[SerializeField]
	private ProbeCamera.ID _id;
	[SerializeField]
	private float _fadeInLength = 1f;
}
