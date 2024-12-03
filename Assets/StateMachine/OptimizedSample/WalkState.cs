using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : BaseState
{
	public override void OnEnter(Enemy enemy)
	{
		curEnemy = enemy;
		curEnemy.walkRoad = new Vector3(Random.Range(1,10), 0.5f, Random.Range(1,10));
		Debug.Log(curEnemy.walkRoad);
	}
	public override void LogicUpdate()
	{
		if(Vector3.Distance(curEnemy.transform.position,curEnemy.walkRoad) < 0.1f)
		{
			curEnemy.curState = curEnemy.idleState;
			curEnemy.timer = 0f;
		}else
		{
			curEnemy.transform.position = Vector3.MoveTowards(curEnemy.transform.position,curEnemy.walkRoad,curEnemy.walkSpeed * Time.deltaTime);
		}
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
