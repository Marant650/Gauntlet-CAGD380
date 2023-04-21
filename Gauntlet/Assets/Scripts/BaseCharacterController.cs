using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BaseCharacterController : MonoBehaviour
{
    Vector2 moveInput;
    Vector3 moveDirection;
    public PlayerData warrior;
    private float runSpeed;
    private Rigidbody rb;
    public Transform shotPosition;
    private bool shoot = true;
    public float fireRate;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(moveInput.x, 0, moveInput.y) * warrior.runSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if(moveInput != Vector2.zero)
        {
            transform.forward = new Vector3(moveInput.x,0,moveInput.y);
        }

       // transform.Translate(new Vector3(moveInput.x , 0, moveInput.y) * runSpeed * Time.deltaTime);

    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();        
        Debug.Log(moveInput);
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        if (shoot)
        {
            Instantiate(warrior.shotPrefab, shotPosition.position, shotPosition.rotation);
            shoot = false;
            StartCoroutine(ShotCoolDown());
        }
        
    }

    IEnumerator ShotCoolDown()
    {
        yield return new WaitForSeconds(fireRate);
        shoot = true;
    }
}
