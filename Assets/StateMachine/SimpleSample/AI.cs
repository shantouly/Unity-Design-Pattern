using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using UnityEngine;

public enum StateType
{
	Idle,
	Walk,
	Run,
	Attack,
	Patrol
	// so on ...
}

/// <summary>
/// A simple method to implement a state machine, but with high coupling
/// </summary>
public class AI : MonoBehaviour
{
	[SerializeField]
	private float moveSpeed;
	private StateType curState;
	// 用来测试，当大于某一值时则切换状态
	private float timer;
	private float middleTime = 3f;
	private bool isWalk;
	private Vector3 walkRoad;
	
	void Start()
	{
		curState = StateType.Idle;
	}	
	
	void Update()
	{
		TimeCount();
		switch(curState)
		{
			case StateType.Idle:
				OnIdle();
				break;
			case StateType.Walk:
				OnWalk();
				break;
			case StateType.Run:
				OnRun();
				break;
			case StateType.Attack:
				OnAttack();
				break;
			case StateType.Patrol:
				OnPatrol();
				break;
		}
	}
	
	private void TimeCount()
	{
		timer += Time.deltaTime;
		if(timer >= middleTime && !isWalk)
		{
			isWalk = true;
			curState = StateType.Walk;
			walkRoad = new Vector3(Random.Range(0,10),0.5f,Random.Range(0,10));
			Debug.Log(walkRoad);
		}
	}
	
	private void OnIdle()
	{
		Debug.Log("In idle state......");
	}
	
	private void OnWalk()
	{
		if(Vector2.Distance(transform.position,walkRoad) < 0.1f)
		{
			curState = StateType.Idle;
			timer = 0;
			isWalk = false;
		}else
		{
			transform.position = Vector3.MoveTowards(transform.position,walkRoad,moveSpeed * Time.deltaTime);
		}
	}
	
	private void OnRun()
	{
		// implement the OnRun function ...
	}
	
	private void OnAttack()
	{
		// implement the OnAttack function ... 
	}
	
	private void OnPatrol()
	{
		// implement the OnPatrol function ... 
	}
}
