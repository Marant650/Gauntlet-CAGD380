using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnGhost());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnEnemy()
    {

    }

    private IEnumerator SpawnGhost()
    {
        while (true)
        {
            Instantiate(enemyPrefab, transform.position + Vector3.forward, Quaternion.identity);
            yield return new WaitForSeconds(3);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "projectile")
        {
            Destroy(gameObject);
        }
    }
}
