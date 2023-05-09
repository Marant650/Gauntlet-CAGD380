using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    public Animator warriorAnimation;
    public Animator wizardAnimation;
    public Animator elfAnimation;
    public Animator valkyrieAnimation;

    public GameObject warriorPrefab;
    public GameObject wizardPrefab;
    public GameObject elfPrefab;
    public GameObject valkyriePrefab;
    public GameObject level1;

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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            warriorAnimation.enabled = true;
            wizardAnimation.enabled = false;
            elfAnimation.enabled = false;
            valkyrieAnimation.enabled = false;
            playerOneClass = "warrior";
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            warriorAnimation.enabled = false;
            wizardAnimation.enabled = true;
            elfAnimation.enabled = false;
            valkyrieAnimation.enabled = false;
            playerOneClass = "wizard";
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            warriorAnimation.enabled = false;
            wizardAnimation.enabled = false;
            elfAnimation.enabled = true;
            valkyrieAnimation.enabled = false;
           playerOneClass = "elf";
        }

        if (Input.GetKey(KeyCode.LeftArrow))
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
                Instantiate(warriorPrefab, Vector3.zero, Quaternion.identity);
            }
            
            if (playerOneClass == "wizard")
            {
                Instantiate(wizardPrefab, Vector3.zero, Quaternion.identity);
            }
            
            if (playerOneClass == "elf")
            {
                Instantiate(elfPrefab, Vector3.zero, Quaternion.identity);
            }
            
            if (playerOneClass == "valkyrie")
            {
                Instantiate(valkyriePrefab, Vector3.zero, Quaternion.identity);
            }
            level1.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
