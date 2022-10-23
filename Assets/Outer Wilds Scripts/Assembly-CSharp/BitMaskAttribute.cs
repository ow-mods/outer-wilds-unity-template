using UnityEngine;
using System;

public class BitMaskAttribute : PropertyAttribute
{
	public Type propType;

	public BitMaskAttribute(Type aType)
	{
		propType = aType;
	}
}
