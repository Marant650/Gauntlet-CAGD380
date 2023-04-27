using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    private PlayerData character;
    public GameObject player;
    public int damage = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            player = collision.gameObject;
            player.GetComponent<BaseCharacterController>().character.health -= player.GetComponent<BaseCharacterController>().character.armorStrength * damage;
            Destroy(gameObject);
        }
    }
}
