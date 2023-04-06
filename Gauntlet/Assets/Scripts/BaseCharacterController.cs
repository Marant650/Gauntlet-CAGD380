using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BaseCharacterController : MonoBehaviour
{
    Vector2 moveInput;    
    public PlayerData warrior;
    private float runSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        runSpeed = warrior.runSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveInput.x * runSpeed * Time.deltaTime, 0, moveInput.y * runSpeed * Time.deltaTime);
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        
        Debug.Log(moveInput);
    }
}
