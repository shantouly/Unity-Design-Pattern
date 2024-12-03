using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public BaseState curState;
	public BaseState walkState;
	public BaseState idleState;
	[HideInInspector]public float timer;
	private float waittime;
	[Header("基本的参数")]
	public float walkSpeed;
	public float runSpeed;
	[HideInInspector] public Vector3 walkRoad;
	
	protected virtual void Awake()
	{
		timer = 0;
		waittime = 3f;
	}
	
	void OnEnable()
	{
		curState = idleState;
		curState.OnEnter(this);
	}
	
	void Update()
	{
		curState.LogicUpdate();
		TimeCounter();
	}
	
	void TimeCounter()
	{
		timer += Time.deltaTime;
		if(timer >= waittime && curState == idleState)
		{
			curState = walkState;
			curState.OnEnter(this);
		}
	}
	
	void FixedUpdate()
	{
		curState.PhysicsUpdate();
	}
	
	void OnDisable()
	{
		curState.OnExit();
	}
}
