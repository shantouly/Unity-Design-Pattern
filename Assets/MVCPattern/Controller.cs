using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVC
{
	/// <summary>
	/// MVC --> Controller Role : Receive user input, update models, and update views
	/// </summary>
	public class Controller : MonoBehaviour
	{
		private Model playerModel;
		private View playerView;
		
		void Start()
		{
			playerModel = new Model();
			playerView = GetComponent<View>();
		}
		
		void Update()
		{
			if(Input.GetKeyDown(KeyCode.Space))
			{
				playerModel.Score++;
				playerView.UpdateScore(playerModel.Score);
			}
		}
	}
}
