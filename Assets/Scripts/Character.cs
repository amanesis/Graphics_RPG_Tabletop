using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string characterName;
    public int healthPoints;
    public int armorClass;
    public int attackRange;
    public int moveRange;

    // Other character-specific properties and methods

    public void TakeDamage(int damage)
    {
        // Reduce healthPoints by the damage amount
        healthPoints -= damage;

        // Check if the character has been defeated
        if (healthPoints <= 0)
        {
            Defeated();
        }
    }

    private void Defeated()
    {
        // Handle character defeat logic
        // E.g., play defeat animation, disable controls, etc.
        Debug.Log(characterName + " has been defeated!");
    }
}

