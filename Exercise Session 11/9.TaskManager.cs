using UnityEngine;
using System.Collections.Generic;

public class TaskManager : MonoBehaviour
{
    private Queue<string> taskQueue = new Queue<string>();

    void Start()
    {
        taskQueue.Enqueue("Collect coins");
        taskQueue.Enqueue("Defeat the enemy");
        taskQueue.Enqueue("Unlock the door");
        taskQueue.Enqueue("Reach the finish line");

        Debug.Log("All tasks:");

        foreach (var task in taskQueue)
        {
            Debug.Log("Task: " + task);
        }

        while (taskQueue.Count > 0)
        {
            Debug.Log("Current Task: " + taskQueue.Peek());
            string currentTask = taskQueue.Dequeue();
            Debug.Log("Processing: " + currentTask);
            Debug.Log("Remaining tasks: " + taskQueue.Count);
        }

        Debug.Log("All tasks are completed.");
    }
}