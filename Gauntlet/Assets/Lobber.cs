using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lobber : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float reatreatDistance;

    public Transform player;

    public float startTimeBetweenShots;
    public float timeBetweenShots;

    public Transform projectileSpawner;
    public GameObject projectile;
    private Vector3 enemyToPlayerVector;
    private Vector3 targetdirection;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        enemyToPlayerVector = player.transform.position - transform.position;
        targetdirection = enemyToPlayerVector.normalized;
        if (Vector3.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else if(Vector3.Distance(transform.position, player.position) < stoppingDistance && Vector3.Distance(transform.position, player.position) > reatreatDistance)
        {

            transform.position = this.transform.position;
            ShootProjectile();
        }
        else if(Vector3.Distance(transform.position, player.position) < reatreatDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }
    }

    private void ShootProjectile()
    {
        transform.forward = targetdirection;
        if (timeBetweenShots <= 0)
        {
            Instantiate(projectile, projectileSpawner.transform.position, transform.rotation);
            timeBetweenShots = startTimeBetweenShots;
        }
        else
        {
            timeBetweenShots -= Time.deltaTime;
        }
    }
}
