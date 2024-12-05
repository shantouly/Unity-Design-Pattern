using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Role : MonoBehaviour
{
	public abstract void Walk();
	public abstract void Jump();
	public abstract void Fire();
	// other character behaviours
}
