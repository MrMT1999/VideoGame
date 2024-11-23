using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventureGame : MonoBehaviour
{
    // Player variables
    public int health = 50;
    public int energy = 30;
    public bool hasWeapon = false;
    public bool isEnemyVisible = true;

    // Enemy variables (in an Array)
    public Enemy[] enemies = new Enemy[]
    {
        new Enemy("Goblin", 70),
        new Enemy("Orc", 80),
        new Enemy("Dragon", 100)
    };

    public int currentEnemyIndex = 0;

    void Update()
    {
        Enemy currentEnemy = enemies[currentEnemyIndex]; //access elements of Array with constructor in Class Enemy

        // Attack conditions
        if (hasWeapon && energy > 20)
        {
            switch (currentEnemy.type)
            {
                case "Goblin":
                    currentEnemy.health -= 30;
                    break;
                case "Orc":
                    currentEnemy.health -= 20;
                    break;
                case "Dragon":
                    currentEnemy.health -= 10;
                    break;
            }

            if (currentEnemy.health <= 0)
            {
                Debug.Log("Enemy defeated!");
                // Switch to the next enemy
                currentEnemyIndex = (currentEnemyIndex + 1) % enemies.Length;
            }
        }
        else if (!hasWeapon) //or hasWeapon == false
        {
            Debug.Log("You cannot attack without a weapon!");
        }

        // Escape conditions
        if (isEnemyVisible && energy < 20)
        {
            if (currentEnemy.type == "Dragon")
            {
                Debug.Log("You cannot escape from the Dragon!");
            }
            else
            {
                Debug.Log("You escaped successfully!");
            }
        }

        // Search for resources
        if (!isEnemyVisible && energy < 10)
        {
            Debug.Log("You found an energy potion!");
            energy += 20;
        }
    }

    public class Enemy
    {        
        public string type;
        public int health;

        public Enemy(string type, int health)
        {
            //using Constructor in this part to assign type and health
            this.type = type;
            this.health = health;
        }
    }
}