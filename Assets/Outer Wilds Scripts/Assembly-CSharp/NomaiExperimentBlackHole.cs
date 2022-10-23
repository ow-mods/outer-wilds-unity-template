using UnityEngine;

[RequireComponent(typeof(Collider))]
public class NomaiExperimentBlackHole : MonoBehaviour
{
	[SerializeField]
	private NomaiExperimentWhiteHole _whiteHole;
	[SerializeField]
	private SurveyorProbe _duplicateProbe;
}
