using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class Pickable : Interactable{


    public override void Awake()
    {
        base.Awake();

    }

    public override void Start()
    {
        base.Start();
    }

    public override void Interact(SelectElement newParent)
    {
        base.Interact(newParent);
        
        if(!newParent.isBusy){
            if(transform.parent != null){
                 if(transform.parent.GetComponent<LeavePlace>() != null){
                     transform.parent.GetComponent<LeavePlace>().full = false;
                }
            }
            newParent.isBusy = true;
            transform.parent = MainCamera.instance.transform;
            transform.position = newParent.ObjectPos.position;
            newParent.carrying = this;
            
        }
        


    }
}