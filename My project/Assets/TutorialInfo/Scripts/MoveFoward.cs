using UnityEngine;

public class MoveFoward : MonoBehaviour
{
    public float speed = 40; // Speed at which the object moves forward
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); // Move the object forward based on the speed and time
    }
}
