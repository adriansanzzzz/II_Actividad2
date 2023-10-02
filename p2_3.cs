using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2_3 : MonoBehaviour
{
    public Vector3 vectorA;
    public Vector3 vectorB;

    // Start is called before the first frame update
    void Start()
    {
      
    }
    

    // Update is called once per frame
    void Update()
    {
        //lo pongo en el update para que se pueda ver en todo momento los resultados
        float magnitudeA = vectorA.magnitude;
        float magnitudeB = vectorB.magnitude;

        Debug.Log("Magnitud de vectorA: " + magnitudeA);
        Debug.Log("Magnitud de vectorB: " + magnitudeB);
        
        float angleDegrees = Vector3.Angle(vectorA, vectorB);
        Debug.Log("Ángulo entre vectorA y vectorB: " + angleDegrees + " grados");

        float distance = Vector3.Distance(vectorA, vectorB);
        Debug.Log("Distancia entre los puntos representados por vectorA y vectorB: " + distance);

        if (vectorA.y > vectorB.y)
        {
            Debug.Log("vectorA está a una altura mayor que vectorB.");
        }
        else if (vectorA.y < vectorB.y)
        {
            Debug.Log("vectorB está a una altura mayor que vectorA.");
        }
        else
        {
            Debug.Log("Ambos vectores están a la misma altura.");
        } 
    }
}
