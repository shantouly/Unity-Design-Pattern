using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace MVC
{
	/// <summary>
	/// MVC --> Role : Display data and receive user input
	/// </summary>
	public class View : MonoBehaviour
	{
		public Text scoreText;
		public void UpdateScore(int score)
		{
			scoreText.text = score.ToString();
		}
	}
}
