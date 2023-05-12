using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public CharacterSelect characterSelect;

    public PlayerData warrior;
    public PlayerData wizard;
    public PlayerData elf;
    public PlayerData valkyrie;

    public Text playerOneClassName;
    public Text playerOneHealth;
    public Text playerOneScore;

    private void Update()
    {
        SetPlayerOneUI();
    }

    private void SetPlayerOneUI()
    {
        if(characterSelect.playerOneClass == "warrior")
        {
            playerOneClassName.text = "Warrior";
            playerOneHealth.text = "Health: " + Mathf.Round(warrior.health);
            warrior.health -= 1 * Time.deltaTime; 
            playerOneScore.text = "Score: " + Mathf.Round(warrior.score);
            playerOneClassName.color = Color.red;
            playerOneHealth.color = Color.red;
            playerOneScore.color = Color.red;
        }
        
        if (characterSelect.playerOneClass == "wizard")
        {
            playerOneClassName.text = "Wizard";
            playerOneHealth.text = "Health: " + Mathf.Round(wizard.health);
            wizard.health -= 1 * Time.deltaTime;
            playerOneScore.text = "Score: " + Mathf.Round(wizard.score);
            playerOneClassName.color = Color.yellow;
            playerOneHealth.color = Color.yellow;
            playerOneScore.color = Color.yellow;
        }
        
        if (characterSelect.playerOneClass == "elf")
        {
            playerOneClassName.text = "Elf";
            playerOneHealth.text = "Health: " + Mathf.Round(elf.health);
            elf.health -= 1 * Time.deltaTime;
            playerOneScore.text = "Score: " + Mathf.Round(elf.score);
            playerOneClassName.color = Color.green;
            playerOneHealth.color = Color.green;
            playerOneScore.color = Color.green;
        }

        if (characterSelect.playerOneClass == "valkyrie")
        {
            playerOneClassName.text = "Valkyrie";
            playerOneHealth.text = "Health: " + Mathf.Round(valkyrie.health);
            valkyrie.health -= 1 * Time.deltaTime;
            playerOneScore.text = "Score: " + Mathf.Round(valkyrie.score);
            playerOneClassName.color = Color.blue;
            playerOneHealth.color = Color.blue;
            playerOneScore.color = Color.blue;
        }
    }
}
