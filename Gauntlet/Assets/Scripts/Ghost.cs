using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public GameObject player;
    public int damage = 10;
  
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            player = collision.gameObject;
            player.GetComponent<BaseCharacterController>().character.health -= player.GetComponent<BaseCharacterController>().character.armorStrength * damage;
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "projectile")
        {           
            Destroy(gameObject);
        }
    }
}
