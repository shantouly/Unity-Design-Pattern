using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Define state abstract classes
/// </summary>
public abstract class BaseState
{
	protected Enemy curEnemy;
	// When state switch to another state
	public abstract void OnEnter(Enemy enemy);
	// Use it in Update function
	public abstract void LogicUpdate();
	// Use it in FixUpdate function
	public abstract void PhysicsUpdate();
	// Use it in OnDisable function
	public abstract void OnExit();
}
