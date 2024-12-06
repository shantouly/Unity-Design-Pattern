using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactoryPattern
{
	public enum ItemType
	{
		Health,
		speed
	}
	public class ItemFactory
	{
		public static Item CreateItem(ItemType itemType)
		{
			ItemType type = itemType;
			Item item = null;
			switch(type)
			{
				case ItemType.Health:
					item = new HealthPotion();
				break;
				case ItemType.speed:
					item = new SpeedBoost();
				break;
				
				// ...... and so on, you can add
			}
			
			return item;
		}
	}
}
