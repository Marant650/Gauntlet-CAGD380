using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCompleted : MonoBehaviour
{
    public GameObject gameCompletedScreen;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            gameCompletedScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
