using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetDataBaseLoader : IResourceLoader
{
	public void LoadResource(string resourcePath)
	{
		Debug.Log("AssetDataBase : " + resourcePath);
		// 编辑器模式下，使用AssetDataBase加载资源的具体实现......
	}
}
