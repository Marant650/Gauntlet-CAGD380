using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private GameObject character;
    public float projectileSpeed;
    // Start is called before the first frame update
    void Start()
    {
        projectileSpeed = GameObject.FindGameObjectWithTag("Player").GetComponent<BaseCharacterController>().character.shotTravelSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward *projectileSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
