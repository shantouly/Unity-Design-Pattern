using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GameObject testObject;
	
	void Start()
	{
		ObjectPool.Instance.PreLoad(testObject,500);
	}
	
	public void Test()
	{
		StartCoroutine(CreateObj());
	}
	
	private IEnumerator CreateObj()
	{
		float t = 0;
		for(int i =0;i< 500;i++)
		{
			int x = Random.Range(-30,30);
			int y = Random.Range(-30,30);
			int z = Random.Range(-30,30);
			GameObject newObj = ObjectPool.Instance.GetObject(testObject,new Vector3(x,y,z),Quaternion.identity);
			ObjectPool.Instance.PutObject(newObj,2f);
			yield return null;
			t += Time.deltaTime;
			Debug.Log(i);
		}
		Debug.Log("所用的时间："+t);
	}
}
