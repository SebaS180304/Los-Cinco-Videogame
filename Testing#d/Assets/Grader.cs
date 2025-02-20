using System;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.InputSystem;

class Grader:MonoBehaviour{

    public virtual void Start() 
    {
        ComponentsManager.instance.Check += CheckState;
    }

    public virtual void OnDisable() 
    {
        ComponentsManager.instance.Check -= CheckState;
    }
    public virtual void CheckState(object sender, EventArgs t){

    }
}

