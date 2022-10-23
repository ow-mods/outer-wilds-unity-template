using UnityEngine;

[RequireComponent(typeof(OWRigidbody))]
public class RelativeAnchor : MonoBehaviour
{
	[SerializeField]
	private float _anchorRange = 1000f;
}
