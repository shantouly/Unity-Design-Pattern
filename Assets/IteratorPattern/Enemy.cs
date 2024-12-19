using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IteratorPattern
{
	public class Enemy
	{
		public string Name{get;private set;}
		public string Health{get;private set;}
		
		public Enemy(string Name,string Health)
		{
			this.Name = Name;
			this.Health = Health;
		}
	}
}
