using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEnemy : MonoBehaviour
{
    private PlayerData character;
    public GameObject player;
    public int damage = 50;
    public int maxDamageInflicted;
    public int health;
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
        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player = collision.gameObject;

        }

        if (collision.gameObject.tag == "projectile")
        {
            health -= 1;
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
        if(maxDamageInflicted < 200)
        {
            player.GetComponent<BaseCharacterController>().character.health -= player.GetComponent<BaseCharacterController>().character.armorStrength * damage;
            maxDamageInflicted += damage;
        }
       
    }



    private IEnumerator damageTimer()
    {
        canTakeDamage = false;
        yield return new WaitForSeconds(damageTimeout);
        canTakeDamage = true;

    }
}
