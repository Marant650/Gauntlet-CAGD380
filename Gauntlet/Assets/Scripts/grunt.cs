using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grunt : MonoBehaviour
{
    private PlayerData character;
    public GameObject player;
    public int damage = 15;
    // public int attackCooldown;

    public float damageTimeout = 2f;
    private bool canTakeDamage = true;
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
        if (collision.gameObject.tag == "Player")
        {
            player = collision.gameObject;
            
        }

        if (collision.gameObject.tag == "projectile")
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && canTakeDamage)
        {
            AttackPlayer();
            StartCoroutine(damageTimer());
        }
           
    }

    private void AttackPlayer()
    {
        player.GetComponent<BaseCharacterController>().character.health -= player.GetComponent<BaseCharacterController>().character.armorStrength * damage;
    }

    //Weapon Collider Script
    private void OnTriggerEnter(Collider hit)
    {

        if (canTakeDamage && hit.gameObject.tag == "Player")
        {

        }

    }

    private IEnumerator damageTimer()
    {
        canTakeDamage = false;
        yield return new WaitForSeconds(damageTimeout);
        canTakeDamage = true;

    }
}
