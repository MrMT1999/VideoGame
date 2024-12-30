using UnityEngine;
using System.Collections.Generic;

public class CustomerRequestManager : MonoBehaviour
{
    private Queue<string> customerRequests = new Queue<string>();

    void Start()
    {
        customerRequests.Enqueue("Purchase game coins");
        customerRequests.Enqueue("Request technical support");
        customerRequests.Enqueue("Level up character");
        customerRequests.Enqueue("Claim daily reward");
        customerRequests.Enqueue("Unlock new stages");

        Debug.Log("Processing customer requests...");

        while (customerRequests.Count > 0)
        {
            string currentRequest = customerRequests.Dequeue();
            Debug.Log("Processing: " + currentRequest);
            Debug.Log("Remaining requests: " + customerRequests.Count);
        }

        Debug.Log("All requests have been processed!");
    }
}