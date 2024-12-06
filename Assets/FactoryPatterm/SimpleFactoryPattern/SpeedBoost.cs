using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactoryPattern
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
			Debug.Log("增加了移动速度");
		}
	}
}

