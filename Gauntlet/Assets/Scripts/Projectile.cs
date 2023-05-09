using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float _projectileSpeed;
    private int score;
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
        if(collision.gameObject.tag == "Enemy")
        {
            player.character.score += 10;
            Destroy(gameObject);
        }
        
    }
}
