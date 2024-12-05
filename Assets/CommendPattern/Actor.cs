using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : Role
{
    public override void Walk()
    {
        Debug.Log("walk!!");
    }

    public override void Jump()
    {
        throw new System.NotImplementedException();
    }

    public override void Fire()
    {
        throw new System.NotImplementedException();
    }
}
