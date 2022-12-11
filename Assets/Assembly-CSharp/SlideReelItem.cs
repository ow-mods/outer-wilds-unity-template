using UnityEngine;

[RequireComponent(typeof(SlideCollectionContainer))]
public class SlideReelItem : OWItem
{
	[SerializeField]
	private TransformAnimator _animator;
	[SerializeField]
	private GameObject _destroyedReelPrefab;
}
