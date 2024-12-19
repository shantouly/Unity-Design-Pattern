using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetBundleLoader : IResourceLoader
{
	public void LoadResource(string resourcePath)
	{
		Debug.Log("AssetBundle :" + resourcePath);
		// 从AssetBundle上加载资源的具体实现......
	}
}
