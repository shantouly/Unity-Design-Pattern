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
		
		// ���Ͱ汾��ΪEnemy�ĵ�����������ֵΪEnemy
		public IEnumerator<Enemy> GetEnumerator()
		{
			foreach(var enemy in enemies)
			{
				yield return enemy;
			}
		}
		
		// �Ƿ��͵İ汾��Ϊ�˼����Զ����б���
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
