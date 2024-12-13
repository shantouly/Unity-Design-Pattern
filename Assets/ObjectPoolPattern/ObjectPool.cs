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
	
	// ����� ---> key:���������;value:������д�ŵĶ���ʹ�ö��д�ţ��Ƚ��ȳ�
	private Dictionary<string,Queue<GameObject>> objectpools;
	
	// ������д�ŵ����Ķ��������
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
	/// �Ӷ�����л�ȡ����
	/// </summary>
	/// <param name="obj">��Ҫ�ĵ�����</param>
	/// <param name="position"></param>
	/// <param name="rotation"></param>
	/// <returns></returns>
	public GameObject GetObject(GameObject obj,Vector3 position,Quaternion rotation)
	{
		// ���û�������������Ķ���صĻ����ͳ�ʼ����������
		if(!objectpools.ContainsKey(obj.name))
		{
			objectpools.Add(obj.name,new Queue<GameObject>());
		}
		
		// �����Ϊ�գ�����������
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
	/// �Ѷ���Żص��������
	/// </summary>
	/// <param name="obj">Ҫ�ŻصĶ���</param>
	/// <param name="delayTime">�ӳ�ִ�е�ʱ��</param>
	public void PutObject(GameObject obj,float delayTime)
	{
		// ��������������������
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
	/// Ԥ�ȶ�����еĶ���
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
