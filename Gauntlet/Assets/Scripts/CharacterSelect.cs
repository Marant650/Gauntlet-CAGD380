using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    private string _selectedClass = "none";

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
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
            _selectedClass = "warrior";
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            warriorAnimation.enabled = false;
            wizardAnimation.enabled = true;
            elfAnimation.enabled = false;
            valkyrieAnimation.enabled = false;
            _selectedClass = "wizard";
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            warriorAnimation.enabled = false;
            wizardAnimation.enabled = false;
            elfAnimation.enabled = true;
            valkyrieAnimation.enabled = false;
            _selectedClass = "elf";
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            warriorAnimation.enabled = false;
            wizardAnimation.enabled = false;
            elfAnimation.enabled = false;
            valkyrieAnimation.enabled = true;
            _selectedClass = "valkyrie";
        }

        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
            if (_selectedClass == "warrior")
            {
                Instantiate(warriorPrefab, Vector3.zero, Quaternion.identity);
            }
            
            if (_selectedClass == "wizard")
            {
                Instantiate(wizardPrefab, Vector3.zero, Quaternion.identity);
            }
            
            if (_selectedClass == "elf")
            {
                Instantiate(elfPrefab, Vector3.zero, Quaternion.identity);
            }
            
            if (_selectedClass == "valkyrie")
            {
                Instantiate(valkyriePrefab, Vector3.zero, Quaternion.identity);
            }
            Destroy(this);
        }
    }
}
