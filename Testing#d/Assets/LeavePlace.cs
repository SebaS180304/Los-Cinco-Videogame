using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LeavePlace : Interactable{

    [SerializeField]
    private Transform LeavePos;

    public bool full;


    public override void Awake()
    {
        base.Awake();
    }

    public override void Start()
    {
        base.Start();
    }

    public override void Interact(SelectElement Player)
    {
        if(Player.isBusy && !full){
            Player.isBusy = false;
            full = true;
            Player.carrying.transform.parent = transform;
            Player.carrying.transform.position = LeavePos.position;
        }
    }
}