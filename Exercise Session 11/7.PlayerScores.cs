using UnityEngine;
using System.Collections.Generic;

public class PlayerScores : MonoBehaviour
{
    void Start()
    {
        Dictionary<string, int> scores = new Dictionary<string, int>();

        scores.Add("Reza", 45);
        scores.Add("Amin", 90);
        scores.Add("Farid", 88);
        scores.Add("Mahla", 90);

        Debug.Log("List of players and scores:");
        foreach (KeyValuePair<string, int> player in scores)
        {
            Debug.Log(player.Key + ": " + player.Value);
        }

        string playerName = "Ali";

        if (scores.ContainsKey(playerName))
        {
            Debug.Log("Score for " + playerName + ": " + scores[playerName]);
        }

        string topPlayer = "";
        int topScore = 0;

        foreach (KeyValuePair<string, int> player in scores)
        {
            if (player.Value > topScore)
            {
                topPlayer = player.Key;
                topScore = player.Value;
            }
        }

        Debug.Log("Player with the most points: " + topPlayer + " with points: " + topScore);
    }
}