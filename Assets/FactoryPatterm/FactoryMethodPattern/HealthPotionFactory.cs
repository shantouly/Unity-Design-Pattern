using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMethodPattern
{
	public class HealthPotionFactory : ItemFactory
	{
		public Item CreateItem()
		{
			return new HealthPotion();
		}
	}
}

