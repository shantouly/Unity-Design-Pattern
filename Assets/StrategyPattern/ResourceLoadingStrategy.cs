using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����Ҫ�̳�monobehaviour���ˣ�����Ҫִ��������������ڵķ���
public class ResourceLoadingStrategy
{
	private IResourceLoader loader;
	public ResourceLoadingStrategy(IResourceLoader loader)
	{
		this.loader = loader;
	}
	
	public void LoadResource(string resourcePath)
	{
		loader.LoadResource(resourcePath);
	}
}
