using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
	public static Controller instance;
	public static Controller Instance
	{
		get
		{
			return instance;
		}
	}
	private KeyCode[] keyCodes = {KeyCode.Space, KeyCode.F , KeyCode.Q};
	private Commend walk;
	private Commend jump;
	private Commend fire;
	private Commend curCommend;
	[SerializeField] private Role actor1;
	
	void Awake()
	{
		if(instance != null)
		{
			Destroy(gameObject);
		}else
		{
			instance = this;
		}
		walk = new WalkCommend();
		jump = new JumpCommend();
		fire = new FireCommend();
	}
	void Update()
	{
		curCommend = InputHandler();
		
		if(curCommend != null)
		{
			curCommend.Execute(actor1);
		}
	}
	
	private Commend InputHandler()
	{
		if(Input.GetKeyDown(keyCodes[0]))
		{
			return jump;
		}
		if(Input.GetKeyDown(keyCodes[1]))
		{
			return fire;
		}
		if(Input.GetKeyDown(keyCodes[2]))
		{
			return walk;
		}
		
		return null;
	}
}
