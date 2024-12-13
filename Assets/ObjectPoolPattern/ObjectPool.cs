using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
	private static ObjectPool instance;
	public static ObjectPool Instance
	{
		get
		{
			return instance;
		}
	}
	
	// 对象池 ---> key:对象池名称;value:对象池中存放的对象，使用队列存放，先进先出
	private Dictionary<string,Queue<GameObject>> objectpools;
	
	// 对象池中存放的最大的对象的数量
	private int maxCount = int.MaxValue;
	public int MaxCount
	{
		get
		{
			return maxCount;
		}
		set
		{
			maxCount = Mathf.Clamp(value,0,int.MaxValue);
		}
	}
	void Awake()
	{
		if(instance == null)
		{
			instance = this;
		}else
		{
			Destroy(gameObject);
		}
		
		objectpools = new Dictionary<string, Queue<GameObject>>();
	}
	
	
	/// <summary>
	/// 从对象池中获取对象
	/// </summary>
	/// <param name="obj">想要的到对象</param>
	/// <param name="position"></param>
	/// <param name="rotation"></param>
	/// <returns></returns>
	public GameObject GetObject(GameObject obj,Vector3 position,Quaternion rotation)
	{
		// 如果没有这种种类对象的对象池的话，就初始化这个对象池
		if(!objectpools.ContainsKey(obj.name))
		{
			objectpools.Add(obj.name,new Queue<GameObject>());
		}
		
		// 对象池为空，创建新物体
		if(objectpools[obj.name].Count == 0)
		{
			GameObject newObject = Instantiate(obj,position,rotation);
			newObject.name = obj.name;
			
			return newObject;
		}
		
		GameObject getObj = objectpools[obj.name].Dequeue();
		getObj.SetActive(true);
		getObj.transform.position = position;
		getObj.transform.rotation = rotation;
		return getObj;
	}
	
	/// <summary>
	/// 把对象放回到对象池中
	/// </summary>
	/// <param name="obj">要放回的对象</param>
	/// <param name="delayTime">延迟执行的时间</param>
	public void PutObject(GameObject obj,float delayTime)
	{
		// 超过了最大的数量，销毁
		if(objectpools[obj.name].Count > MaxCount)
		{
			Destroy(obj,delayTime);
		}else
		{
			StartCoroutine(ExecutePut(obj,delayTime));
		}
	}
	
	public IEnumerator ExecutePut(GameObject obj,float delayTime)
	{
		yield return new WaitForSeconds(delayTime);
		obj.SetActive(false);
		objectpools[obj.name].Enqueue(obj);
	}
	
	/// <summary>
	/// 预热对象池中的对象
	/// </summary>
	/// <param name="obj"></param>
	/// <param name="number"></param>
	public void PreLoad(GameObject obj,int number)
	{
		if(!objectpools.ContainsKey(obj.name))
		{
			objectpools.Add(obj.name,new Queue<GameObject>());
		}
		
		for(int i =0;i < number;i++)
		{
			GameObject newObject = Instantiate(obj);
			newObject.name = obj.name;
			newObject.SetActive(false);
			objectpools[obj.name].Enqueue(newObject);
		}
	}
}
