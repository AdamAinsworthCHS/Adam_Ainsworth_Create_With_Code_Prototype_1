using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 3, 7);
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = player.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
