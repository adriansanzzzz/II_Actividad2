using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2_8 : MonoBehaviour
{
    public string esferaTag = "second_blue_esfera"; // Etiqueta de la esfera
    public string esfera_groupTag = "first_blue_esfera"; // Etiqueta de la esfera
    public string cuboTag = "red_cube"; // Etiqueta del cubo

    private Material esferaMaterial;
    private GameObject esferaMasCercanaAlCubo; 
    private GameObject esferaMasLejanaCubo;
    void Start()
    {
        GameObject[] esferas = GameObject.FindGameObjectsWithTag(esferaTag);
        GameObject[] group_esferas = GameObject.FindGameObjectsWithTag(esfera_groupTag);
        GameObject cubo = GameObject.FindWithTag(cuboTag);


        float distanciaMinima = float.MaxValue;

        foreach (GameObject esfera in esferas)
        {
            var distanceToCubo = Vector3.Distance(cubo.transform.position, esfera.transform.position);

            if (distanceToCubo < distanciaMinima)
            {
                distanciaMinima = distanceToCubo;
                esferaMasCercanaAlCubo = esfera;
            }
        }

        Vector3 min_newPositionEsfera = new Vector3(esferaMasCercanaAlCubo.transform.position.x, esferaMasCercanaAlCubo.transform.position.y + 1.0f, esferaMasCercanaAlCubo.transform.position.z);
        esferaMasCercanaAlCubo.transform.position = min_newPositionEsfera;
    }

    void Update()
    {
        GameObject[] esferas = GameObject.FindGameObjectsWithTag(esferaTag);
        GameObject cubo = GameObject.FindWithTag(cuboTag);

        float distanciaMaxima = float.MinValue;
        foreach (GameObject esfera in esferas)
        {
            var distanceToCubo = Vector3.Distance(cubo.transform.position, esfera.transform.position);

            if (distanceToCubo > distanciaMaxima)
            {
                distanciaMaxima = distanceToCubo;
                esferaMasLejanaCubo = esfera;
            }
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            esferaMaterial = esferaMasLejanaCubo.GetComponent<Renderer>().material;
            esferaMaterial.color = Color.green;
        }
       
    }
}
