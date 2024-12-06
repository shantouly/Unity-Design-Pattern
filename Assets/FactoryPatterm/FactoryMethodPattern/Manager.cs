using System.Collections;
using System.Collections.Generic;
using SimpleFactoryPattern;
using UnityEngine;

namespace FactoryMethodPattern
{
	public class Manager : MonoBehaviour
	{
		ItemFactory itemFactory;
		Item item;
		[SerializeField] private ItemType itemType;
		void Update()
		{
			switch(itemType)
			{
				case ItemType.Health:
					itemFactory = new HealthPotionFactory();
					item = itemFactory.CreateItem();
					item.Use();
				break;
				case ItemType.speed:
					itemFactory = new SpeedBoostFactory();
					item = itemFactory.CreateItem();
					item.Use();
				break;
			}
		}
	}
}

