using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranger : Character
{
    public int dexterity;
    public int constitution;

    // Other ranger-specific properties and methods

    private void Start()
    {
        // Set the ranger's attributes
        healthPoints = 10 + constitution;
        armorClass = 10 + dexterity;
        attackRange = 3;
        moveRange = 3;
    }
}

