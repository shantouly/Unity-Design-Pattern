using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���ڲ��Եĵ���B
/// </summary>
public class SingletonB : Singleton<SingletonB>
{
	public void Show()
	{
		Debug.Log("This is singletonB!");
	}
}
