using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DisplayPlayerData : MonoBehaviour
{
    public PlayerData playerData;

    [SerializeField] private GameObject player;

    [SerializeField] private TextMeshProUGUI playerHealth;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerData = player.GetComponent<BaseCharacterController>().character;
    }

    // Update is called once per frame
    void Update()
    {
        playerHealth.text = "Health: " + playerData.health; 
    }
}
