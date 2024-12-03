using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : BaseState
{
	public override void OnEnter(Enemy enemy)
	{
		curEnemy = enemy;
	}
	public override void LogicUpdate()
	{
		// ......
	}


	public override void PhysicsUpdate()
	{
		// ......
	}

	public override void OnExit()
	{
		// ......
	}
}
