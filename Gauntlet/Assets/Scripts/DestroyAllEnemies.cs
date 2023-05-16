using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAllEnemies : MonoBehaviour
{
    private void OnEnable()
    {
        EventBus.Subscribe(PowerupEvent.PowerupUsed, DestroyEnemy);
    }

    private void OnDisable()
    {
        EventBus.Unsubscribe(PowerupEvent.PowerupUsed, DestroyEnemy);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DestroyEnemy()
    {
        Destroy(this.gameObject);
    }
}
