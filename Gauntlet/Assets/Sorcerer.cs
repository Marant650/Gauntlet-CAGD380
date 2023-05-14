using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Sorcerer : MonoBehaviour
{
    NavMeshAgent agent;
    public float startTimeBetweenShots;
    public float timeBetweenShots;


    public float startTimebewteenInvis;
    public float timeBetweenInvis;

    private bool invisibilityActivated = false;   

    public GameObject player1;

    public GameObject projectile;
    public Transform projectileSpawner;

    private Transform stoppingDistance;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player1 = GameObject.FindGameObjectWithTag("Player");
        InvokeRepeating("ActivateInvisibility", 2f, 2f);      
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = player1.transform.position;
        
        if(timeBetweenInvis == startTimebewteenInvis)
        {
            invisibilityActivated = false;
        }
        if (Vector3.Distance(transform.position, player1.transform.position) <= 15)
        {
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
        else
        {
            timeBetweenShots -= Time.deltaTime;
        }
    }

    private void ActivateInvisibility()
    {
        if (gameObject.GetComponent<MeshRenderer>().enabled == true && gameObject.GetComponent<CapsuleCollider>().enabled == true)
        { 
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<CapsuleCollider>().enabled = false;
        }
        else if (gameObject.GetComponent<MeshRenderer>().enabled == false && gameObject.GetComponent<CapsuleCollider>().enabled == false)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.GetComponent<CapsuleCollider>().enabled = true;
        }


    }




}
