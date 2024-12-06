using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMethodPattern
{
	public enum ItmType
	{
		Health,
		Speed
	}
	public interface ItemFactory
	{
		public Item CreateItem();
	}
}
