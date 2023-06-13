using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Priest : Character
{
    public int charisma;
    public int dexterity;
    public int constitution;

    // Other priest-specific properties and methods

    private void Start()
    {
        // Set the priest's attributes
        healthPoints = 10 + constitution;
        armorClass = 10 + dexterity;
        attackRange = 2;
        moveRange = 1;
    }
}

