using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class melee : MonoBehaviour
{
    private BaseCharacterController character;
    // Start is called before the first frame update
    void Start()
    {
        character = transform.GetComponentInParent<BaseCharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            character.character.score += 10;
            Debug.Log("Enemy Collided with");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
