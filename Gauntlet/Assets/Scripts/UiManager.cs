using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiManager : MonoBehaviour
{
    public CharacterSelect characterSelect;

    public Text playerOneHealth;

    private void Start()
    {
        if(characterSelect.playerOneClass == "warrior")
        {
            playerOneHealth.color = Color.red;
        }
    }
}
