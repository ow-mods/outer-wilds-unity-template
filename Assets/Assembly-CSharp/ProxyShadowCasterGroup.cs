using UnityEngine;

public class ProxyShadowCasterGroup : MonoBehaviour
{
	[EnumFlags]
	[SerializeField]
	private ProxyShadowCascade.Flags _cascadeFlags = (ProxyShadowCascade.Flags)(-1);
	[SerializeField]
	private bool _earlyDraw;
	[SerializeField]
	private bool _dynamic;
}
