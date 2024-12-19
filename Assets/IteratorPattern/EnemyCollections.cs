using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IteratorPattern
{
	public class EnemyCollections : IEnumerable<Enemy>
	{
		public List<Enemy> enemies = new List<Enemy>();
		public void AddEnemy(Enemy enemy)
		{
			enemies.Add(enemy);
		}
		
		// 泛型版本，为Enemy的迭代器，返回值为Enemy
		public IEnumerator<Enemy> GetEnumerator()
		{
			foreach(var enemy in enemies)
			{
				yield return enemy;
			}
		}
		
		// 非泛型的版本，为了兼容性而进行保留
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
