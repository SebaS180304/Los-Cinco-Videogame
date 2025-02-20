using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class ComponentsManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static ComponentsManager instance;
    private PlayerInput pInput;
    public event EventHandler Check; 

    private int MaxItems;
    private int grade;
    private void Awake() {
        if(instance == null){
            instance = this;
        }else{
            Destroy(gameObject);
        }
        pInput = GetComponent<PlayerInput>();
      
    }
   

    public void OnActivate(){
        Check?.Invoke(this, EventArgs.Empty);
        ShowResults();
    }

    public void ChangeCal(int val){
        grade += val;
        MaxItems += Mathf.Abs(val);
    }
    private void ShowResults(){
        UICanvas.instance.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = grade.ToString() + " / " + MaxItems.ToString();
    }






}
