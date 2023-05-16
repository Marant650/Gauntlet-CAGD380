using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class demon : MonoBehaviour
{
    public float startTimeBetweenShots;
    public float timeBetweenShots;
    NavMeshAgent agent;


    public GameObject player1;
    private Vector3 enemyToPlayerVector;
    private Vector3 targetdirection;

    public GameObject projectile;
    public Transform projectileSpawner;

    private Transform stoppingDistance;

    public int rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player1 = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = player1.transform.position;
        enemyToPlayerVector = player1.transform.position - transform.position;
        targetdirection = enemyToPlayerVector.normalized;
        if (Vector3.Distance(transform.position, player1.transform.position) <= 15)
        {
            transform.forward = targetdirection;
            ShootProjectile();
        } 
        
        
    }

    private void ShootProjectile()
    {
        if (timeBetweenShots <= 0)
        {
                     
            Instantiate(projectile, projectileSpawner.transform.position, transform.rotation);
            timeBetweenShots = startTimeBetweenShots;
        }
        else {
            timeBetweenShots -= Time.deltaTime;
            }
    }

    
}
