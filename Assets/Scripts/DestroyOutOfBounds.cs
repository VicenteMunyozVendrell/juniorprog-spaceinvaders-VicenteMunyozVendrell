using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topBound = 30.0f;
    [SerializeField] private float lowerBounds = -10.0f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z >  topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
        }
    }
}
