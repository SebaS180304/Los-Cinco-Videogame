using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class TemporalMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed;
    private Vector2 value;
    private PlayerInput pInput;
    void Awake()
    {
        pInput = GetComponent<PlayerInput>();
    }

    public void FixedUpdate(){
        value *= MainCamera.instance.transform.forward  * speed * Time.fixedDeltaTime;
        transform.position -= new Vector3(value.x, 0,value.y) ;
    }

    // Update is called once per frame
    void Update()
    {
        value = pInput.actions["Move"].ReadValue<Vector2>();
    }
}
