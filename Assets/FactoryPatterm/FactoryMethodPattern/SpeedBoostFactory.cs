using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMethodPattern
{
	public class SpeedBoostFactory : ItemFactory
	{
		public Item CreateItem()
		{
			return new SpeedBoost();
		}
	}
}
