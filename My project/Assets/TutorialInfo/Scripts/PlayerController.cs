using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float horizontalInput;
    public float xRange = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal"); // Get the horizontal input from the user (e.g., arrow keys or A/D keys)
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * 10); // Move the player horizontally based on the input and time
        if (transform.position. x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); // Keep the player within the left boundary
        }
        
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z); // Keep the player within the right boundary
        }
        if (Input.GetKeyDown(KeyCode.Space)) // Check if the space key is pressed
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation); // Spawn a projectile at the player's position with its original rotation
        }
    }
}
