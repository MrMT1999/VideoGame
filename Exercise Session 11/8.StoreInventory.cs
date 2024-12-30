using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreInventory : MonoBehaviour
{
    void Start()
    {
        Dictionary<string, int> inventory = new Dictionary<string, int>();

        inventory.Add("Laptop", 10);
        inventory.Add("Keyboard", 15);
        inventory.Add("Monitor", 20);
        inventory.Add("Mouse", 15);

        Debug.Log("Initial store inventory:");

        foreach (KeyValuePair<string, int> product in inventory)
        {
            Debug.Log(product.Key + ": " + product.Value + " units");
        }

        string productToUpdate = "Mouse";

        if (inventory.ContainsKey(productToUpdate))
        {
            inventory[productToUpdate] += 10;
            Debug.Log("New inventory for " + productToUpdate + ": " + inventory[productToUpdate]);
        }

        int minStock = 12;

        string productToRestock = "";

        foreach (KeyValuePair<string, int> product in inventory)
        {
            if (product.Value < minStock)
            {
                productToRestock = product.Key;
                break;
            }
        }

        if (!string.IsNullOrEmpty(productToRestock))
        {
            inventory[productToRestock] += 13;
            Debug.Log("Restocked " + productToRestock + " with 13 units.");
        }
    }

    void Update()
    {
        
    }
}