using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
	private void Start() {
		// singletonA
		SingletonA.Instace.Show();
		
		// singletonB
		SingletonB.Instace.Show();
	}
}
