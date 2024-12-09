using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVC
{
	/// <summary>
	/// MVC --> Model Role : Storage, processing, and updating of processed data
	/// </summary>
	public class Model : MonoBehaviour
	{
		private int health;
		private int score;
		public int Health
		{
			get
			{
				return health;
			}
			set
			{
				health = value;
			}
		}
		public int Score
		{
			get
			{
				return score;
			}
			set
			{
				score = value;
			}
		}
	}
}
