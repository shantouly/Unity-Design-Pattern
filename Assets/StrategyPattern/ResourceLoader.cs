using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceLoader : IResourceLoader
{
	public void LoadResource(string resourcePath)
	{
		Debug.Log("Resource :" + resourcePath);
		// ֱ�Ӵ�Resource�м����ļ��ķ���������ʵ��......
	}
}
