using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class SelectElement : MonoBehaviour
{
    //Variables
    public bool isBusy;
    public Interactable carrying;
    //Components
    private Transform origin;
    //TempValues
    private RaycastHit hittedObj;
    private Interactable selected;
    //Global Constants 
    [SerializeField]
    private float MAX_DISTANCE;
    [SerializeField]
    private LayerMask InteractableObjects;
    [SerializeField]
    private Material material;
    public Transform ObjectPos;
    



    void Awake()
    {
        isBusy = false;
        origin = transform.GetChild(0);
    }
    public void OnInteract(){
        Debug.DrawRay(origin.position, origin.forward*MAX_DISTANCE, Color.red, 2.0f);
        selected?.Interact(this);
        
    }


    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(origin.position, origin.forward, out hittedObj, MAX_DISTANCE, InteractableObjects) ){
           //Encontrar objecto 
            if(selected == null || hittedObj.collider.name != selected.name){
                //verificar que sea nuevo o diferente del anterior
                if(selected != null){
                    //si es diferente quitarle al anterior la textura y texto
                    selected.RemoveSelected(material);
                }
                //Ponerle al nuevo la textura y texto
                selected = hittedObj.collider.gameObject.GetComponent<Interactable>();
                selected.ShowSelected(material);
            }
        }else if(selected != null){
            //Si no hay nada y hay algo seleccionado, quitarle la textura y texto
            selected.RemoveSelected(material);
            selected = null;
        }
    }

    

    
}
