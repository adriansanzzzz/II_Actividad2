using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2_1 : MonoBehaviour
{
    private int arraySize = 10; 
    private int[] randomArray; // Array para almacenar los valores aleatorios.
    public int minValue = 0;   // Valor mínimo para los números aleatorios.
    public int maxValue = 25;  // Valor máximo para los números aleatorios.

    // Start is called before the first frame update
    void Start()
    {
        randomArray = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            randomArray[i] = Random.Range(minValue, maxValue + 1); // Numeros aleatorios entre 0 y 25, +1 para que incluya el 25.
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        int randomIndex = Random.Range(0, arraySize);
        randomArray[randomIndex] = Random.Range(minValue, maxValue + 1);

        // Muestra en la consola los valores mayores que 15.
        for (int i = 0; i < arraySize; i++)
        {
            if (randomArray[i] > 15)
            {
                Debug.Log("Valor mayor que 15 encontrado en la posición " + i + "  con valor  " + randomArray[i]);
            }
        }
        
    }
}
