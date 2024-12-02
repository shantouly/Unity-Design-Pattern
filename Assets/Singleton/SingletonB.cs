using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 用于测试的单例B
/// </summary>
public class SingletonB : Singleton<SingletonB>
{
	public void Show()
	{
		Debug.Log("This is singletonB!");
	}
}
