using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topBound = 30.0f;
    [SerializeField] private float lowerBounds = -10.0f;


    // Update is called once per frame
    void Update()
    {
        //Si el objeto sale de los límites de la pantalla se elimina.
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBounds)
        {
            //Si el objeto sale del límite inferior se notifica al jugador.
            Debug.Log("Has fallado");
            Destroy(gameObject);
        }
    }
}
