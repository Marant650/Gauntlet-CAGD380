using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewPlayerManager : MonoBehaviour
{
    public List<string> currentPlayersClasses = new List<string>();
    public GameObject warriorPrefab;
    public GameObject wizardPrefab;
    public GameObject elfPrefab;
    public GameObject valkyriePrefab;
    public GameObject newPlayerRandomClass;

    private void Update()
    {
        PlayerInputManager.instance.playerPrefab = newPlayerRandomClass;
    }

    public void PlayerJoined()
    {
        RandomClassPicker();
    }

    public bool IsClassInGame(string className)
    {
        if (currentPlayersClasses.Contains(className))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void RandomClassPicker()
    {
        float randomNumber = Random.Range(0.0f, 4.0f);
        if (randomNumber < 1.0f)
        {
            if (IsClassInGame("warrior"))
            {
                RandomClassPicker();
            }
            else
            {
                newPlayerRandomClass = warriorPrefab;
                currentPlayersClasses.Add("warrior");
            }
        }

        if (randomNumber >= 1.0f && randomNumber < 2.0f)
        {
            if (IsClassInGame("wizard"))
            {
                RandomClassPicker();
            }
            else
            {
                newPlayerRandomClass = wizardPrefab;
                currentPlayersClasses.Add("wizard");
            }
        }

        if (randomNumber >= 2.0f && randomNumber < 3.0f)
        {
            if (IsClassInGame("elf"))
            {
                RandomClassPicker();
            }
            else
            {
                newPlayerRandomClass = elfPrefab;
                currentPlayersClasses.Add("elf");
            }
        }

        if (randomNumber >= 3.0f && randomNumber < 4.0f)
        {
            if (IsClassInGame("valkyrie"))
            {
                RandomClassPicker();
            }
            else
            {
                newPlayerRandomClass = valkyriePrefab;
                currentPlayersClasses.Add("valkyrie");
            }
        }
    }
}
