using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// 用枚举变量更好管理事件的key，不需要用字符串
/// </summary>

public class EventCenter : MonoBehaviour
{
	public static EventCenter instance;
	
	public static EventCenter Instance
	{
		get
		{	
			return instance;
		}
	}
	
	public Dictionary<string,IEventfo> _eventDic = new Dictionary<string, IEventfo>();
	
	void Awake()
	{
		if(instance != null)
		{
			Destroy(gameObject);
		}else
		{
			instance = this;
		}
	}
	
	/// <summary>
	/// 注册event
	/// </summary>
	/// <param name="name"></param>
	/// <param name="action"></param>
	public void AddEventListener(string name,UnityAction action)
	{
		if(_eventDic.ContainsKey(name))
		{
			(_eventDic[name] as EventFo).actions += action;
		}else
		{
			_eventDic.Add(name,new EventFo(action));
		}
	}
	
	/// <summary>
	/// 触发event
	/// </summary>
	/// <param name="name"></param>
	/// <param name="action"></param>
	public void EventTrigger(string name)
	{
		if(_eventDic.ContainsKey(name))
		{
			(_eventDic[name] as EventFo)?.actions?.Invoke();
		}
	}
	
	/// <summary>
	/// 移除event
	/// </summary>
	/// <param name="name"></param>
	/// <param name="action"></param>
	public void RemoveEventListener(string name,UnityAction action)
	{
		if(_eventDic.ContainsKey(name))
		{
			(_eventDic[name] as EventFo).actions -= action;
		}
	}
	
	/// <summary>
	/// ClearEvent
	/// </summary>
	/// <param name="name"></param>
	/// <param name="action"></param>
	public void ClearEventListener(string name,UnityAction action)
	{
		_eventDic.Clear();
	}
}


