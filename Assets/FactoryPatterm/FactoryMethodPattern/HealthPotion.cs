using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMethodPattern
{
	public class HealthPotion : Item
	{
		
		public HealthPotion()
		{
			name = "����ҩˮ";
		}
		public override void Use()
		{
			base.Use();
			Debug.Log("����ֵ����");
		}
	}
}

