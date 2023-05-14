using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float _projectileSpeed;
    private BaseCharacterController player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<BaseCharacterController>();
        _projectileSpeed = GameObject.FindGameObjectWithTag("Player").GetComponent<BaseCharacterController>().character.shotTravelSpeed;
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * _projectileSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Bone Pile")
        {
            player.character.score += 10;
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "Death")
        {
            player.character.score += 1;
            Destroy(gameObject);
        }
        
        if(collision.gameObject.tag == "Wall"|| collision.gameObject.tag == "Door")
        {
            Destroy(this.gameObject);
        }
    }
}
