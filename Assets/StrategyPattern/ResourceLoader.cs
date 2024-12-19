using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceLoader : IResourceLoader
{
	public void LoadResource(string resourcePath)
	{
		Debug.Log("Resource :" + resourcePath);
		// 直接从Resource中加载文件的方法，具体实现......
	}
}
