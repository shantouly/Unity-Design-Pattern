using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMethodPattern
{
	public class SpeedBoost : Item
	{
		
		public SpeedBoost()
		{
			name = "����ҩ��";
		}
		public override void Use()
		{
			base.Use();
			Debug.Log("�ٶ�����");
		}
	}
}
