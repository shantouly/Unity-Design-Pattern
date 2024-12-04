using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManaer : MonoBehaviour
{
	public static GameManaer instance;
	public static GameManaer Instance
	{
		get
		{
			return instance;
		}
	}
	
	private float threshold = 3f;
	public float timer;
	public Vector3 destionation;
	public bool isMove;
	public float speed = 7f;
	
	void Awake()
	{
		if(instance != null)
		{
			Destroy(gameObject);
		}else
		{
			instance = this;
		}
	}
	
	void Update()
	{
		TimeCounter();
	}
	
	private void TimeCounter()
	{
		timer += Time.deltaTime;
		if(timer >= threshold && !isMove)
		{
			isMove = true;
			destionation = new Vector3(Random.Range(0,10),0.5f,Random.Range(0,10));
			EventCenter.instance.EventTrigger("walk");
		}
	}
}
