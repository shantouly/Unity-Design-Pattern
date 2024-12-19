using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 不需要继承monobehaviour类了，不需要执行里面的生命周期的方法
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
