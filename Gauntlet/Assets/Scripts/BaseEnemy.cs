using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BaseEnemy : MonoBehaviour
{
    NavMeshAgent agent;

    public GameObject[] _players;

    public GameObject chaseTarget;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        _players = GameObject.FindGameObjectsWithTag("Player");
        CalculateClosestPlayer();
        
        agent.destination = chaseTarget.transform.position;
    }

    private void CalculateClosestPlayer()
    {
        float playerOneDistance = Vector3.Distance(transform.position, _players[0].transform.position);
        float playerTwoDistance = Vector3.Distance(transform.position, _players[1].transform.position);
        float playerThreeDistance = Vector3.Distance(transform.position, _players[2].transform.position);
        float playerFourDistance = Vector3.Distance(transform.position, _players[3].transform.position);

        if(playerOneDistance > playerTwoDistance)
        {
            chaseTarget = _players[1];
        }
        else if(playerOneDistance < playerTwoDistance)
        {
            chaseTarget = _players[0];
        }
    }
}
