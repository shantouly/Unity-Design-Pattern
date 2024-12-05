using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkCommend : Commend
{
	public override void Execute(Role character)
	{
		character.Walk();
	}

	public override void Unexecute()
	{
		// If your game need this function
	}
}
