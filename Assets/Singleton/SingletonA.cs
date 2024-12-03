using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 用于测试的单例A
/// </summary>
public class SingletonA : Singleton<SingletonA>
{
	public void Show()
	{
		Debug.Log("This is singletonA!");
	}
}