using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
	private static T instance;
	
	public static T Instace
	{
		get
		{
			return instance;
		}
	}
	
	protected virtual void Awake()
	{
		if(instance != null)
		{
			Destroy(gameObject);
		}else
		{
			instance = this as T;
		}
	}
	
	protected virtual void OnDestroy()
	{
		if(instance == this)
		{
			instance = null;
		}
	}
}


