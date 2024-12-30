using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    void Start()
    {
        int[][] enemies = new int[4][];

        enemies[0] = new int[] { 98, 45 }; // first enemy
        enemies[1] = new int[] { 50, 30, 20 }; // Second Enemy
        enemies[2] = new int[] { 150, 25, 5, 30 }; // Third Enemy
        enemies[3] = new int[] { 200, }; // Fourth Enemy

        // Print Enemy Details
        for (int i = 0; i < enemies.Length; i++)
        {
            string enemyInfo = "Enemy " + (i + 1) + " Attributes: ";
            for (int j = 0; j < enemies[i].Length; j++)
            {
                enemyInfo += enemies[i][j] + " ";
            }
            Debug.Log(enemyInfo);
        }

        // Average Enemy Health
        float totalHealth = 0;
        for (int i = 0; i < enemies.Length; i++)
        {
            totalHealth += enemies[i][0]; 
        }
        float averageHealth = totalHealth / enemies.Length;
        Debug.Log("Total Enemy Health: " + averageHealth);
    }
}