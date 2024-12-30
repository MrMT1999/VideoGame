using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager: MonoBehaviour
{
    void Start()
    {
    
        int[][] playerScores = new int[3][];

        playerScores[0] = new int[] { 82, 150, 42 }; // Player 1
        playerScores[1] = new int[] { 55, 98 };       // Player 2
        playerScores[2] = new int[] { 400, 20, 34, 13 }; // Player 3

        for (int i = 0; i < playerScores.Length; i++)
        {
            int totalScore = 0;

            for (int j = 0; j < playerScores[i].Length; j++)
            {
                totalScore += playerScores[i][j];
            }

            Debug.Log("Total player points: " + totalScore);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
