using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetBundleLoader : IResourceLoader
{
	public void LoadResource(string resourcePath)
	{
		Debug.Log("AssetBundle :" + resourcePath);
		// ��AssetBundle�ϼ�����Դ�ľ���ʵ��......
	}
}
