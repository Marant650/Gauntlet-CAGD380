using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BaseCharacterController : MonoBehaviour
{
    Vector2 moveInput;
    public bool isMoving;
    public PlayerData character;
    public PlayerData characterPreset;
    private Rigidbody rb;
    public Transform shotPosition;
    private bool _ableToShoot = true;
    private float _fireRate = 0.5f;
    private float _shotPauseTime = 0.15f;

    private Transform melee;

    private void Awake()
    {
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

        melee = transform.Find("melee hitbox");
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
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
            melee.gameObject.SetActive(false);
        }

        if (isMoving)
        {
            melee.gameObject.SetActive(true);
        }

        if (moveInput != Vector2.zero)
            transform.forward = new Vector3(moveInput.x, 0, moveInput.y);
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        isMoving = true;
        //Debug.Log(moveInput);
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
}
