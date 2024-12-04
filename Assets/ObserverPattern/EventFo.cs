using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventFo : IEventfo
{
	public UnityAction actions;
	public EventFo(UnityAction action)
	{
		actions += action;
	}
}
