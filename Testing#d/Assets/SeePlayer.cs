using UnityEngine;

public class SeePlayer : MonoBehaviour
{
    //Class only used for the text, or anything to look into the player
    void Update()
    {
       transform.rotation = Quaternion.LookRotation(transform.position-MainCamera.instance.transform.position);
    }
}
