using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorProjectile : MonoBehaviour
{
    private float _projectileSpeed;
    public PlayerData warriorData;


    private void Start()
    {
        _projectileSpeed = warriorData.shotTravelSpeed;
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * _projectileSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Bone Pile")
        {
            warriorData.score += 10;
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Death")
        {
            warriorData.score += 1;
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Door")
        {
            Destroy(this.gameObject);
        }
    }
}
