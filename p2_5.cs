using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2_5 : MonoBehaviour
{
    public string esferaTag = "blue_esfera"; // Etiqueta de la esfera
    public string cuboTag = "red_cube"; // Etiqueta del cubo 

    // Start is called before the first frame update
    void Start()
    {
        GameObject esfera = GameObject.FindWithTag(esferaTag);
        GameObject cubo = GameObject.FindWithTag(cuboTag);

        var distanceToEsfera = Vector3.Distance(cubo.transform.position, esfera.transform.position);
        Debug.Log("Distancia entre cubo y la esfera: " + distanceToEsfera);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
