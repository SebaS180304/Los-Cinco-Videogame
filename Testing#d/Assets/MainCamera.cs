using UnityEngine;

public class MainCamera : MonoBehaviour
{
    //Singletone used as a way to find the transform of the player's camera,
    //  as well as a way to manage anything that will be accesed my other scripts to avoid problems
    public static MainCamera instance;

    void Awake()
    {
        if(instance == null){
            instance = this;
        }else{
            Destroy(gameObject);
        }
    }
}
