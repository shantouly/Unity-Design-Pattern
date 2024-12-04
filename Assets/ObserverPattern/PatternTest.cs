using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternTest : MonoBehaviour
{
	 private bool isWalking = false; // 用于控制是否行走

	void Start()
	{
		EventCenter.instance.AddEventListener("walk", StartWalking);
		EventCenter.instance.AddEventListener("idle",Idle);
	}

	void Update()
	{
		if (isWalking)
		{
			WalkToDestination();
		}
	}

	// 开始行走的方法（由事件触发）
	public void StartWalking()
	{
		isWalking = true; // 开始行走
	}

	// 行走逻辑
	private void WalkToDestination()
	{
		if (Vector3.Distance(transform.position, GameManaer.instance.destionation) < 0.1f)
		{
			isWalking = false; // 停止行走
			GameManaer.instance.isMove = false;
			GameManaer.instance.timer = 0f;
		}
		else
		{
			Debug.Log("Walking...");
			transform.position = Vector3.MoveTowards(transform.position, GameManaer.instance.destionation, GameManaer.instance.speed * Time.deltaTime);
		}
	}
	
	private void Idle()
	{
		// ......
		Debug.Log("Idle");
	}
}
