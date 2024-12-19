using System.Collections;
using System.Collections.Generic;
using IteratorPattern;
using UnityEngine;

namespace IteratorPattern
{
	public class IteratorPatternTest : MonoBehaviour
	{
		void Start()
		{
			EnemyCollections enemyCollections = new EnemyCollections();
			
			enemyCollections.AddEnemy(new Enemy("Goblin", "100"));
			enemyCollections.AddEnemy(new Enemy("Orc", "200"));
			enemyCollections.AddEnemy(new Enemy("Dragon", "500"));
			
			foreach(var enemy in enemyCollections)
			{
				Debug.Log("Name : " + enemy.Name + "Health :" + enemy.Health);
			}
		}
	}
}
