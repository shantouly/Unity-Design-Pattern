using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactoryPattern
{
	public class HealthPotion : Item
	{
		public HealthPotion()
		{
			name = "生命药水";
		}

		public override void Use()
		{
			base.Use();
			Debug.Log("恢复了10点生命值");
		}
		
	}
}

