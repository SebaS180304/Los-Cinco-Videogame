using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    //Codigo usado para cambiar el texto del objecto asi como manejar la animacion de esta
    protected Transform textCanvas;
    protected Animator anim;
    protected Bounds bounds;
    [SerializeField]
    protected string indication;
    
    protected Renderer renderer;
    
    protected List<Material> materials;
    public virtual void Awake()
    {
        renderer = GetComponent<Renderer>();
        materials = new List<Material>();
        textCanvas = transform.GetChild(0);
        anim = textCanvas.GetComponent<Animator>();
        textCanvas.GetChild(0).GetComponent<TextMeshProUGUI>().text = gameObject.name;
        bounds = GetComponent<MeshFilter>().mesh.bounds;
    }
    public virtual void Start() {
        textCanvas.transform.localPosition = new Vector3 (0, bounds.size.y,0);
    }

    public void ActivateText(){
        textCanvas.gameObject.SetActive(true);
        UICanvas.instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = indication;
        anim.Play("Entry");
    }
    public void Deactivatetext(){
        UICanvas.instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "";
        anim.Play("Exit");
    }

    public virtual void Interact(SelectElement responsable){
    }


    public void ShowSelected(Material material){
        renderer.GetMaterials(materials);
        materials.Add(material);
        renderer.SetMaterials(materials);
        ActivateText();
    }
    public void RemoveSelected(Material material){
        Deactivatetext();
        materials.Remove(material);
        renderer.SetMaterials(materials);
    }
    //Also used as a way to active the different animations in the object

}
