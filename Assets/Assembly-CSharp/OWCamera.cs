using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(Camera))]
public class OWCamera : MonoBehaviour
{
	[SerializeField]
	protected bool _useFarCamera;
	[SerializeField]
	protected float _farCameraDist = 100000f;
	[FormerlySerializedAs("_useSkyboxCamera")]
	[SerializeField]
	protected bool _renderSkybox;
	[SerializeField]
	protected bool _useViewmodels;
	[SerializeField]
	protected float _viewmodelFOV = 70f;
}
