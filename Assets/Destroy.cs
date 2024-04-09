using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the object you want to destroy
        if (collision.gameObject.CompareTag("Death"))
        {
            // Destroy the object this script is attached to
            Destroy(gameObject);
        }
    }
}
