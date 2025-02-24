using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 7.0f;
    private float turnSpeed = 20.0f;
    private float horizontalInput;
    private float forwardInput;
    public Rigidbody projectile;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        // Move the vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the vehicle based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        if (Input.GetKey("space"))
        {
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation);
        }
    }
}
