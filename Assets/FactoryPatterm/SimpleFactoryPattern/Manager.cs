using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactoryPattern
{
	public class Manager : MonoBehaviour
	{
		Item healthPotion;
		Item speedBoost;
		
		void Start()
		{
			healthPotion = ItemFactory.CreateItem(ItemType.Health);
			speedBoost = ItemFactory.CreateItem(ItemType.speed);
			
			healthPotion.Use();
			speedBoost.Use();
		}
	}
}

