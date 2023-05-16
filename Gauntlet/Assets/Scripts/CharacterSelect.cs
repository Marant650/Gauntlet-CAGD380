using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterSelect : MonoBehaviour
{
    public NewPlayerManager NewPlayerManager;

    public GameObject cameraPrefab;

    public Animator warriorAnimation;
    public Animator wizardAnimation;
    public Animator elfAnimation;
    public Animator valkyrieAnimation;

    public GameObject warriorPrefab;
    public GameObject wizardPrefab;
    public GameObject elfPrefab;
    public GameObject valkyriePrefab;
    public GameObject level1;
    public GameObject playerInputManagerObj;

    public string playerOneClass = "none";

    private void Start()
    {
        warriorAnimation.enabled = false;
        wizardAnimation.enabled = false;
        elfAnimation.enabled = false;
        valkyrieAnimation.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            warriorAnimation.enabled = true;
            wizardAnimation.enabled = false;
            elfAnimation.enabled = false;
            valkyrieAnimation.enabled = false;
            playerOneClass = "warrior";
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            warriorAnimation.enabled = false;
            wizardAnimation.enabled = true;
            elfAnimation.enabled = false;
            valkyrieAnimation.enabled = false;
            playerOneClass = "wizard";
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            warriorAnimation.enabled = false;
            wizardAnimation.enabled = false;
            elfAnimation.enabled = true;
            valkyrieAnimation.enabled = false;
            playerOneClass = "elf";
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            warriorAnimation.enabled = false;
            wizardAnimation.enabled = false;
            elfAnimation.enabled = false;
            valkyrieAnimation.enabled = true;
            playerOneClass = "valkyrie";
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (playerOneClass == "warrior")
            {
                GameObject warrior = Instantiate(warriorPrefab, Vector3.zero, Quaternion.identity);
                cameraPrefab.GetComponent<MultiTargetCamera>().cameraTargets.Add(warrior.transform);
            }

            if (playerOneClass == "wizard")
            {
                GameObject wizard = Instantiate(wizardPrefab, Vector3.zero, Quaternion.identity);
                cameraPrefab.GetComponent<MultiTargetCamera>().cameraTargets.Add(wizard.transform);
            }

            if (playerOneClass == "elf")
            {
                GameObject elf = Instantiate(elfPrefab, Vector3.zero, Quaternion.identity);
                cameraPrefab.GetComponent<MultiTargetCamera>().cameraTargets.Add(elf.transform);
            }

            if (playerOneClass == "valkyrie")
            {
                GameObject valkyrie = Instantiate(valkyriePrefab, Vector3.zero, Quaternion.identity);
                cameraPrefab.GetComponent<MultiTargetCamera>().cameraTargets.Add(valkyrie.transform);
            }
            level1.SetActive(true);
            this.gameObject.SetActive(false);
            NewPlayerManager.currentPlayersClasses.Add(playerOneClass);
            playerInputManagerObj.SetActive(true);
        }
    }
}
