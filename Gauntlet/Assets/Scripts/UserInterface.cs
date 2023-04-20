using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour
{
    public PlayerData warrior;
    public PlayerData wizard;
    public PlayerData elf;
    public PlayerData valkyrie;

    public Animator warriorAnimation;
    public Animator wizardAnimation;
    public Animator elfAnimation;
    public Animator valkyrieAnimation;


    private void Start()
    {
        warriorAnimation.enabled = false;
        wizardAnimation.enabled = false;
        elfAnimation.enabled = false;
        valkyrieAnimation.enabled = false;
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            warriorAnimation.enabled = true;
            wizardAnimation.enabled = false;
            elfAnimation.enabled = false;
            valkyrieAnimation.enabled = false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            warriorAnimation.enabled = false;
            wizardAnimation.enabled = true;
            elfAnimation.enabled = false;
            valkyrieAnimation.enabled = false;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            warriorAnimation.enabled = false;
            wizardAnimation.enabled = false;
            elfAnimation.enabled = true;
            valkyrieAnimation.enabled = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            warriorAnimation.enabled = false;
            wizardAnimation.enabled = false;
            elfAnimation.enabled = false;
            valkyrieAnimation.enabled = true;
        }
    }
}
