using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���ڲ��Եĵ���A
/// </summary>
public class SingletonA : Singleton<SingletonA>
{
	public void Show()
	{
		Debug.Log("This is singletonA!");
	}
}