using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefabOnMouseClick : MonoBehaviour
{
    public GameObject prefabToSpawn;

    void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0)) // 0 represents the left mouse button
        {
            // Get the mouse position in the world
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0; // Optionally set the z-coordinate to control the depth

            // Instantiate the prefab at the mouse position
            Instantiate(prefabToSpawn, mousePosition, Quaternion.identity);
        }
    }
}