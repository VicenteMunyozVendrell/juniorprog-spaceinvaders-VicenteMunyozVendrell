using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalinput;
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float xRange = 12.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the player
        horizontalinput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * horizontalinput * Time.deltaTime);

        //Keep the player in bounds
        if (transform.position.x < -xRange)
        { 
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
       
    }
}
