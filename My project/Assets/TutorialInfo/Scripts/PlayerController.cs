using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject projectilePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Check if the space key is pressed
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation); // Create a new projectile at the current position and rotation of the player
        }
        
    }
}
