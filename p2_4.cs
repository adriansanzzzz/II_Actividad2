using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2_4 : MonoBehaviour
{
    public Vector3 posicionEsfera; // Variable para mostrar la posición de la esfera


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        posicionEsfera = transform.position;

        Debug.Log("Posición de la esfera: " + posicionEsfera);

        
    }
}
