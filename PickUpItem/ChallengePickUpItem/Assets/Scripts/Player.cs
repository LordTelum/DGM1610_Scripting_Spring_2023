using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "item")
        {
            // Perform an action when the player is hit by the "item" object
            PrintInventory();
        }
    }

    void PrintInventory()
    {
        // This is just a placeholder for your inventory; replace this with your actual inventory data
        string[] inventory = { "item 1", "item 2", "item 3" };

        // Print the inventory to the console
        Debug.Log("Inventory:");
        for (int i = 0; i < inventory.Length; i++)
        {
            Debug.Log(inventory[i]);
        }
    }
}

