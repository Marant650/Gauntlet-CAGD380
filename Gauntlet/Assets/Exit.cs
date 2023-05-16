using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject currentLevel;
    public GameObject nextLevel;
    public Transform nextLevelSpawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            nextLevel.SetActive(true);
            GoToNextLevel(other.gameObject);
            currentLevel.SetActive(false);
        }
    }

    private void GoToNextLevel(GameObject player)
    {
        player.transform.position = nextLevelSpawnPosition.transform.position;
    }
}
