using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 0, 3);
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (gameObject.name != "Projectile")
        {
            transform.position = player.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name != "Projectile")
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 20);
        }
        if (transform.position.x > player.transform.position.x + 100 || transform.position.y > player.transform.position.y + 100 || transform.position.z > player.transform.position.z + 100)
        {
            if (gameObject.name != "Projectile")
            {
                Destroy(gameObject);
            }
        }
    }
}
