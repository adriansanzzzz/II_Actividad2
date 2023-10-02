using UnityEngine;

public class p2_6 : MonoBehaviour
{
    public string cilindroTag = "green_cil"; // Etiqueta de la esfera
    public string cuboTag = "red_cube"; // Etiqueta del cubo
    public string esferaTag = "blue_esfera"; // Etiqueta de la esfera

    void Start()
    {

       
    }

    void Update()
    {
        // Buscamos los objetos por su etiqueta
        GameObject esfera = GameObject.FindWithTag(esferaTag);
        GameObject cilindro = GameObject.FindWithTag(cilindroTag);
        GameObject cubo = GameObject.FindWithTag(cuboTag);
        
        // Creamos los vectores con las nuevas posicione ( x de la esfera y +5 y -5 para el cilindro y el cubo)
        Vector3 newPositionCilindro = new Vector3(esfera.transform.position.x + 5.0f, cilindro.transform.position.y, cilindro.transform.position.z);
        Vector3 newPositionCubo = new Vector3(esfera.transform.position.x - 5.0f, cubo.transform.position.y, cubo.transform.position.z);

        // Asignamos las nuevas posiciones
        cilindro.transform.position = newPositionCilindro;
        cubo.transform.position = newPositionCubo;
       
    }
}
