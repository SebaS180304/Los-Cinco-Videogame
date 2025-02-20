using UnityEngine;

public class UICanvas : MonoBehaviour
{
    // Singletone for easy acces
    public static UICanvas instance;
    private void Awake() {
        if(instance == null){
            instance = this;
        }else{
            Destroy(gameObject);
        }
    }
}
