using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BaseCharacterController : MonoBehaviour
{
    public UiManager uiManager;
    Vector2 moveInput;
    public bool isMoving;
    public PlayerData character;
    public PlayerData characterPreset;
    private Rigidbody rb;
    public Transform shotPosition;
    private bool _ableToShoot = true;
    private float _fireRate = 0.5f;
    private float _shotPauseTime = 0.15f;

    public GameObject melee;

    private void Awake()
    {
        character.className = characterPreset.className;
        character.health = characterPreset.health;
        character.score = characterPreset.score;
        character.numberOfKeys = characterPreset.numberOfKeys;
        character.numberOfPotions = characterPreset.numberOfPotions;
        character.characterPrefab = characterPreset.characterPrefab;
        character.shotPrefab = characterPreset.shotPrefab;
        character.runSpeed = characterPreset.runSpeed;
        character.armorStrength = characterPreset.armorStrength;
        character.shotStrength = characterPreset.shotStrength;
        character.shotTravelSpeed = characterPreset.shotTravelSpeed;
        character.meleeStrength = characterPreset.meleeStrength;
        character.magicVsGenerators = characterPreset.magicVsGenerators;
        character.magicVsMonsters = characterPreset.magicVsMonsters;
        character.potionShotVsGenerators = characterPreset.potionShotVsGenerators;
        character.potionShotVsMonsters = characterPreset.potionShotVsMonsters;
        character.powerup = characterPreset.powerup;
    }

    private void Start()
    {
        //DontDestroyOnLoad(gameObject);
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(moveInput.x, 0, moveInput.y) * character.runSpeed;
    }

    private void Update()
    {
        if(rb.velocity == Vector3.zero)
        {
            isMoving = false;
            melee.SetActive(false);
        }

        if (isMoving)
        {
            melee.SetActive(true);
        }

        if (moveInput != Vector2.zero)
            transform.forward = new Vector3(moveInput.x, 0, moveInput.y);
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        isMoving = true;
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        if (_ableToShoot)
        {
            Instantiate(character.shotPrefab, shotPosition.position, shotPosition.rotation);
            _ableToShoot = false;
            StartCoroutine(ShotMovementPause());
            StartCoroutine(ShotCoolDown());
        }
    }

    IEnumerator ShotCoolDown()
    {
        yield return new WaitForSeconds(_fireRate);
        _ableToShoot = true;
    }

    IEnumerator ShotMovementPause()
    {
        rb.isKinematic = true;
        yield return new WaitForSeconds(_shotPauseTime);
        rb.isKinematic = false;
    }

    public void UseItem()
    {
        if(character.powerup > 0)
        {
            EventBus.Publish(PowerupEvent.PowerupUsed);
            character.powerup -= 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Food")
        {
            Destroy(other.gameObject);
            character.health += 20;
        }

        if (other.gameObject.tag == "Treasure")
        {
            Destroy(other.gameObject);
            character.score += 100;
        }

        if(other.gameObject.tag == "Key")
        {
            Destroy(other.gameObject);
            character.numberOfKeys++;
        }

        if(other.gameObject.tag == "Door" && character.numberOfKeys > 0)
        {
            Destroy(other.gameObject);
            character.numberOfKeys--;
        }

        if(other.gameObject.tag == "power up")
        {
            character.powerup += 1;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "strength potion")
        {
            character.armorStrength += .1f;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "speed potion")
        {
            character.runSpeed += .5f;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "shotspeed potion")
        {
            character.shotTravelSpeed += .2f;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "shotpower potion")
        {
            character.shotStrength += .2f;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "magic potion")
        {
            character.magicVsMonsters += .3f;
            Destroy(other.gameObject);
        }
    }

    
}
