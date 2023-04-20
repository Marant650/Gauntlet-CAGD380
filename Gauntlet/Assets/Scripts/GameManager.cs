using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public PlayerData[] playerClasses;

    public PlayerData player1Class;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        if (playerClasses.Length > 0 && player1Class == null)
        {
            player1Class = playerClasses[0];
        }
    }

    public void SetCharacter(PlayerData playerClass)
    {
        player1Class = playerClass;
    }

}

