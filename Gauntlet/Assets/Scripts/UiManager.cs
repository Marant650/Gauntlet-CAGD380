using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiManager : MonoBehaviour
{
    public CharacterSelect characterSelect;

    public Text playerOneHealth;
    public Text playerOneScore;

    private void Start()
    {
        SetPlayerOneUI();
    }

    private void SetPlayerOneUI()
    {
        if(characterSelect.playerOneClass == "warrior")
        {
            playerOneHealth.color = Color.red;
            playerOneScore.color = Color.red;
        }
        
        if (characterSelect.playerOneClass == "wizard")
        {
            playerOneHealth.color = Color.yellow;
            playerOneScore.color = Color.yellow;
        }
        
        if (characterSelect.playerOneClass == "elf")
        {
            playerOneHealth.color = Color.green;
            playerOneScore.color = Color.green;
        }

        if (characterSelect.playerOneClass == "valkyrie")
        {
            playerOneHealth.color = Color.blue;
            playerOneScore.color = Color.blue;
        }
    }
}
