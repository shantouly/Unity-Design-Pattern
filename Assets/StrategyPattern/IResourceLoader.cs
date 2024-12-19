using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 资源加载的统一的类，提供统一接口
public interface IResourceLoader
{
	void LoadResource(string resourcePath);
}
