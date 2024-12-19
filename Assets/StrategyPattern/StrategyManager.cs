using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ResourcePathType
{
	AssetDataBase,
	AssetBundle,
	Resource
}
public class StrategyManager : MonoBehaviour
{
	private static StrategyManager instance;
	public static StrategyManager Instance
	{
		get
		{
			return instance;
		}
	}	
	
	private ResourceLoadingStrategy loader; 
	public ResourcePathType pathType;
	void Awake()
	{
		if(instance == null)
		{
			instance = this;
		}else
		{
			Destroy(gameObject);
		}
	}
	
	void Update()
	{
		switch(pathType)
		{
			case ResourcePathType.AssetDataBase:
				loader = new ResourceLoadingStrategy(new AssetDataBaseLoader());
				loader.LoadResource("/.../.../prefab");
			break;
			case ResourcePathType.AssetBundle:
				loader = new ResourceLoadingStrategy(new AssetBundleLoader());
				loader.LoadResource("/.../.../prefab");
			break;
			case ResourcePathType.Resource:
				loader = new ResourceLoadingStrategy(new ResourceLoader());
				loader.LoadResource("/.../.../prefab");
			break;
		}
	}
}
