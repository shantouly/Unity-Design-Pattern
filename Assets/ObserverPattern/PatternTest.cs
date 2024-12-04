using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternTest : MonoBehaviour
{
	 private bool isWalking = false; // ���ڿ����Ƿ�����

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

	// ��ʼ���ߵķ��������¼�������
	public void StartWalking()
	{
		isWalking = true; // ��ʼ����
	}

	// �����߼�
	private void WalkToDestination()
	{
		if (Vector3.Distance(transform.position, GameManaer.instance.destionation) < 0.1f)
		{
			isWalking = false; // ֹͣ����
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
