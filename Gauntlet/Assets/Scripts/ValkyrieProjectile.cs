using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValkyrieProjectile : MonoBehaviour
{
    private float _projectileSpeed;
    public PlayerData valkyrieData;

    private void Start()
    {
        _projectileSpeed = valkyrieData.shotTravelSpeed;
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * _projectileSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Bone Pile")
        {
            valkyrieData.score += 10;
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Death")
        {
            valkyrieData.score += 1;
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Door")
        {
            Destroy(this.gameObject);
        }
    }
}
