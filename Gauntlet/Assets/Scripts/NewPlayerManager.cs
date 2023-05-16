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

    public void PlayerJoined()
    {
        PlayerInputManager.instance.playerPrefab = RandomClassPicker();
    }

    public bool IsClassInGame(string className)
    {
        foreach (string x in currentPlayersClasses)
        {
            if (x.Equals(className))
            {
                Debug.Log(x + " already exists in game");
                return true;
            }
        }
        return false;
    }

    public GameObject RandomClassPicker()
    {
        float randomNumber = Random.Range(0.0f, 4.0f);
        if (randomNumber < 1.0f)
        {
            if (!IsClassInGame("warrior"))
            {
                newPlayerRandomClass = warriorPrefab;
                currentPlayersClasses.Add("warrior");
            }
        }

        if (randomNumber >= 1.0f && randomNumber < 2.0f)
        {
            if (!IsClassInGame("wizard"))
            {
                newPlayerRandomClass = wizardPrefab;
                currentPlayersClasses.Add("wizard");
            }
        }

        if (randomNumber >= 2.0f && randomNumber < 3.0f)
        {
            if (!IsClassInGame("elf"))
            {
                newPlayerRandomClass = elfPrefab;
                currentPlayersClasses.Add("elf");
            }
        }

        if (randomNumber >= 3.0f && randomNumber < 4.0f)
        {
            if (!IsClassInGame("valkyrie"))
            {
                newPlayerRandomClass = valkyriePrefab;
                currentPlayersClasses.Add("valkyrie");
            }
        }

        return newPlayerRandomClass;
    }
}
