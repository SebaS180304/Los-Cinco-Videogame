using System;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.InputSystem;

class ObjectNameCalifier:Grader{
    [SerializeField]
    private string correctObject;

    public override void Start()
    {
        base.Start();
    }
    public override void OnDisable()
    {
        base.OnDisable();
    }
    public override void CheckState(object sender, EventArgs t){
        foreach(Transform child in gameObject.GetComponentInChildren<Transform>()){
            if(child.name == correctObject){
                ComponentsManager.instance.ChangeCal(1);
                return;
            }
        }
        ComponentsManager.instance.ChangeCal(-1);
        
    }
}

