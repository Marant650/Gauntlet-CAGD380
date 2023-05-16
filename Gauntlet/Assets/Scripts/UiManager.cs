using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public CharacterSelect characterSelect;
    public NewPlayerManager newPlayerManager;

    public PlayerData warrior;
    public PlayerData wizard;
    public PlayerData elf;
    public PlayerData valkyrie;

    public Text playerOneClassName;
    public Text playerOneHealth;
    public Text playerOneScore;

    public Image playerOnekey;
    public Image playerOnekey1;
    public Image playerOnekey2;

    public Text playerTwoClassName;
    public Text playerTwoHealth;
    public Text playerTwoScore;

    public Image playerTwokey;
    public Image playerTwokey1;
    public Image playerTwokey2;

    private void Update()
    {
        SetPlayerOneUI();
        SetPlayerTwoUI();
    }


    //PLAYER ONE
    private void SetPlayerOneUI()
    {
        if (characterSelect.playerOneClass == "warrior")
        {
            playerOneClassName.text = "Warrior";
            playerOneHealth.text = "Health: " + Mathf.Round(warrior.health);
            warrior.health -= 1 * Time.deltaTime;
            playerOneScore.text = "Score: " + Mathf.Round(warrior.score);
            playerOneClassName.color = Color.red;
            playerOneHealth.color = Color.red;
            playerOneScore.color = Color.red;
            if (warrior.numberOfKeys == 0)
            {
                playerOnekey.enabled = false;
                playerOnekey1.enabled = false;
                playerOnekey2.enabled = false;
            }
            if (warrior.numberOfKeys == 1)
            {
                playerOnekey.enabled = true;
                playerOnekey1.enabled = false;
                playerOnekey2.enabled = false;
            }
            if (warrior.numberOfKeys == 2)
            {
                playerOnekey.enabled = true;
                playerOnekey1.enabled = true;
                playerOnekey2.enabled = false;
            }
            if (warrior.numberOfKeys == 3)
            {
                playerOnekey.enabled = true;
                playerOnekey1.enabled = true;
                playerOnekey2.enabled = true;
            }
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
            if (wizard.numberOfKeys == 0)
            {
                playerOnekey.enabled = false;
                playerOnekey1.enabled = false;
                playerOnekey2.enabled = false;
            }
            if (wizard.numberOfKeys == 1)
            {
                playerOnekey.enabled = true;
                playerOnekey1.enabled = false;
                playerOnekey2.enabled = false;
            }
            if (wizard.numberOfKeys == 2)
            {
                playerOnekey.enabled = true;
                playerOnekey1.enabled = true;
                playerOnekey2.enabled = false;
            }
            if (wizard.numberOfKeys == 3)
            {
                playerOnekey.enabled = true;
                playerOnekey1.enabled = true;
                playerOnekey2.enabled = true;
            }
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
            if (elf.numberOfKeys == 0)
            {
                playerOnekey.enabled = false;
                playerOnekey1.enabled = false;
                playerOnekey2.enabled = false;
            }
            if (elf.numberOfKeys == 1)
            {
                playerOnekey.enabled = true;
                playerOnekey1.enabled = false;
                playerOnekey2.enabled = false;
            }
            if (elf.numberOfKeys == 2)
            {
                playerOnekey.enabled = true;
                playerOnekey1.enabled = true;
                playerOnekey2.enabled = false;
            }
            if (elf.numberOfKeys == 3)
            {
                playerOnekey.enabled = true;
                playerOnekey1.enabled = true;
                playerOnekey2.enabled = true;
            }
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
            if (valkyrie.numberOfKeys == 0)
            {
                playerOnekey.enabled = false;
                playerOnekey1.enabled = false;
                playerOnekey2.enabled = false;
            }
            if (valkyrie.numberOfKeys == 1)
            {
                playerOnekey.enabled = true;
                playerOnekey1.enabled = false;
                playerOnekey2.enabled = false;
            }
            if (valkyrie.numberOfKeys == 2)
            {
                playerOnekey.enabled = true;
                playerOnekey1.enabled = true;
                playerOnekey2.enabled = false;
            }
            if (valkyrie.numberOfKeys == 3)
            {
                playerOnekey.enabled = true;
                playerOnekey1.enabled = true;
                playerOnekey2.enabled = true;
            }
        }
    }

    //PLAYER TWO
    private void SetPlayerTwoUI()
    {
        if (newPlayerManager.currentPlayersClasses[1] == "warrior")
        {
            playerTwoClassName.text = "Warrior";
            playerTwoHealth.text = "Health: " + Mathf.Round(warrior.health);
            warrior.health -= 1 * Time.deltaTime;
            playerTwoScore.text = "Score: " + Mathf.Round(warrior.score);
            playerTwoClassName.color = Color.red;
            playerTwoHealth.color = Color.red;
            playerTwoScore.color = Color.red;
            if (warrior.numberOfKeys == 0)
            {
                playerTwokey.enabled = false;
                playerTwokey1.enabled = false;
                playerTwokey2.enabled = false;
            }
            if (warrior.numberOfKeys == 1)
            {
                playerTwokey.enabled = true;
                playerTwokey1.enabled = false;
                playerTwokey2.enabled = false;
            }
            if (warrior.numberOfKeys == 2)
            {
                playerTwokey.enabled = true;
                playerTwokey1.enabled = true;
                playerTwokey2.enabled = false;
            }
            if (warrior.numberOfKeys == 3)
            {
                playerTwokey.enabled = true;
                playerTwokey1.enabled = true;
                playerTwokey2.enabled = true;
            }
        }

        if (newPlayerManager.currentPlayersClasses[1] == "wizard")
        {
            playerTwoClassName.text = "Wizard";
            playerTwoHealth.text = "Health: " + Mathf.Round(wizard.health);
            wizard.health -= 1 * Time.deltaTime;
            playerTwoScore.text = "Score: " + Mathf.Round(wizard.score);
            playerTwoClassName.color = Color.yellow;
            playerTwoHealth.color = Color.yellow;
            playerTwoScore.color = Color.yellow;
            if (wizard.numberOfKeys == 0)
            {
                playerTwokey.enabled = false;
                playerTwokey1.enabled = false;
                playerTwokey2.enabled = false;
            }
            if (wizard.numberOfKeys == 1)
            {
                playerTwokey.enabled = true;
                playerTwokey1.enabled = false;
                playerTwokey2.enabled = false;
            }
            if (wizard.numberOfKeys == 2)
            {
                playerTwokey.enabled = true;
                playerTwokey1.enabled = true;
                playerTwokey2.enabled = false;
            }
            if (wizard.numberOfKeys == 3)
            {
                playerTwokey.enabled = true;
                playerTwokey1.enabled = true;
                playerTwokey2.enabled = true;
            }
        }

        if (newPlayerManager.currentPlayersClasses[1] == "elf")
        {
            playerTwoClassName.text = "Elf";
            playerTwoHealth.text = "Health: " + Mathf.Round(elf.health);
            elf.health -= 1 * Time.deltaTime;
            playerTwoScore.text = "Score: " + Mathf.Round(elf.score);
            playerTwoClassName.color = Color.green;
            playerTwoHealth.color = Color.green;
            playerTwoScore.color = Color.green;
            if (elf.numberOfKeys == 0)
            {
                playerTwokey.enabled = false;
                playerTwokey1.enabled = false;
                playerTwokey2.enabled = false;
            }
            if (elf.numberOfKeys == 1)
            {
                playerTwokey.enabled = true;
                playerTwokey1.enabled = false;
                playerTwokey2.enabled = false;
            }
            if (elf.numberOfKeys == 2)
            {
                playerTwokey.enabled = true;
                playerTwokey1.enabled = true;
                playerTwokey2.enabled = false;
            }
            if (elf.numberOfKeys == 3)
            {
                playerTwokey.enabled = true;
                playerTwokey1.enabled = true;
                playerTwokey2.enabled = true;
            }
        }

        if (newPlayerManager.currentPlayersClasses[1] == "valkyrie")
        {
            playerTwoClassName.text = "Valkyrie";
            playerTwoHealth.text = "Health: " + Mathf.Round(valkyrie.health);
            valkyrie.health -= 1 * Time.deltaTime;
            playerTwoScore.text = "Score: " + Mathf.Round(valkyrie.score);
            playerTwoClassName.color = Color.blue;
            playerTwoHealth.color = Color.blue;
            playerTwoScore.color = Color.blue;
            if (valkyrie.numberOfKeys == 0)
            {
                playerTwokey.enabled = false;
                playerTwokey1.enabled = false;
                playerTwokey2.enabled = false;
            }
            if (valkyrie.numberOfKeys == 1)
            {
                playerTwokey.enabled = true;
                playerTwokey1.enabled = false;
                playerTwokey2.enabled = false;
            }
            if (valkyrie.numberOfKeys == 2)
            {
                playerTwokey.enabled = true;
                playerTwokey1.enabled = true;
                playerTwokey2.enabled = false;
            }
            if (valkyrie.numberOfKeys == 3)
            {
                playerTwokey.enabled = true;
                playerTwokey1.enabled = true;
                playerTwokey2.enabled = true;
            }
        }
    }
}

