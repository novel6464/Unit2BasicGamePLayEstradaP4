using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{   
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound) // Check if the object's position on the z-axis exceeds the top boundary
        {
            Destroy(gameObject); // Destroy the object if it goes out of bounds
        }
        else if (transform.position.z < lowerBound) // Check if the object's position on the z-axis is below the lower boundary
        {
            Destroy(gameObject); // Destroy the object if it goes out of bounds
        }
    }
}
