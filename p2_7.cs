using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2_7 : MonoBehaviour
{
    public string cilindroTag = "green_cil"; // Etiqueta del cilindro
    public string cuboTag = "red_cube"; // Etiqueta del cubo

    private Material cilindroMaterial;
    private Material cuboMaterial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject cilindro = GameObject.FindWithTag(cilindroTag);
        GameObject cubo = GameObject.FindWithTag(cuboTag);

         // Obtiene los materiales de los objetos cilindro y cubo
        cilindroMaterial = cilindro.GetComponent<Renderer>().material;
        cuboMaterial = cubo.GetComponent<Renderer>().material;

        // Si se presiona la tecla A
        if (Input.GetKeyDown(KeyCode.A))
        {
            cilindroMaterial.color = Color.yellow;
        }

        // Si se presiona la flecha arriba
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            cuboMaterial.color = Color.blue;
        }
        
    }
}
