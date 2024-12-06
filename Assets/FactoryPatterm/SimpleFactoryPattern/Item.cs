using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactoryPattern
{
	public class Item
	{
		protected string name;
		public virtual void Use()
		{
			Debug.Log("สนำรมห"+name);
		}
	}

}
