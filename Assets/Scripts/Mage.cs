using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Character
{
    public int intelligence;
    public int dexterity;
    public int constitution;

    // Other mage-specific properties and methods

    private void Start()
    {
        // Set the mage's attributes
        healthPoints = 10 + constitution;
        armorClass = 10 + dexterity;
        attackRange = 3;
        moveRange = 1;
    }
}

