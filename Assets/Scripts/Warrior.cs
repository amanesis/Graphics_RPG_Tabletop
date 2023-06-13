using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Character
{
    public int strength;
    public int dexterity;
    public int constitution;

    // Other warrior-specific properties and methods

    private void Start()
    {
        // Set the warrior's attributes
        healthPoints = 10 + constitution;
        armorClass = 10 + dexterity;
        attackRange = 1;
        moveRange = 2;
    }
}
