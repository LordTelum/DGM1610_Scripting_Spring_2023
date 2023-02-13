using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float speed = 1.0f; // The speed at which the pickup moves down the screen

    private void Update()
    {
        // Move the pickup along the Z axis at the specified speed
        transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // If the pickup collides with an object named "Player", destroy the pickup
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
