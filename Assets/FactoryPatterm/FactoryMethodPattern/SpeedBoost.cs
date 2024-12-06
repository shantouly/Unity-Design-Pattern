using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMethodPattern
{
	public class SpeedBoost : Item
	{
		
		public SpeedBoost()
		{
			name = "加速药剂";
		}
		public override void Use()
		{
			base.Use();
			Debug.Log("速度增加");
		}
	}
}
