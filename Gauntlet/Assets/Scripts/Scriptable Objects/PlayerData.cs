using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
    //Shows up in the UI
    public string className;
    public float health;
    public int score;
    public int numberOfKeys;
    public int numberOfPotions;
    public int powerup;

    //Game Objects
    public GameObject characterPrefab;
    public GameObject shotPrefab;

    //Does not show up in UI
    public float runSpeed;
    public float armorStrength;
    public float shotStrength;
    public float shotTravelSpeed;
    public float meleeStrength;
    public float magicVsMonsters;
    public float magicVsGenerators;
    public float potionShotVsMonsters;
    public float potionShotVsGenerators;
}
