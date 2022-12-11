using System;
using UnityEngine;

[Serializable]
public struct EntryData
{
	public string id;
	public Sprite sprite;
	public Sprite altSprite;
	public Vector2 cardPosition;

	public EntryData(string id, Sprite sprite)
	{
		this.id = id;
		this.sprite = sprite;
		this.altSprite = null;
		this.cardPosition = Vector2.zero;
	}
}
