using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : Enemy
{
	protected override void Awake()
	{
		base.Awake();
		walkState = new WalkState();
		idleState = new IdleState();
	}
}
