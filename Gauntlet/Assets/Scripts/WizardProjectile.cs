using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardProjectile : MonoBehaviour
{
    private float _projectileSpeed;
    public PlayerData wizardData;

    private void Start()
    {
        _projectileSpeed = wizardData.shotTravelSpeed;
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * _projectileSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Bone Pile")
        {
            wizardData.score += 10;
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Death")
        {
            wizardData.score += 1;
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Door")
        {
            Destroy(this.gameObject);
        }
    }
}
