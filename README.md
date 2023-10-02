# Práctica 2 - Introducción C# - Scripts
## Asignatura: Interfaces Inteligentes
## Adrián Sanz Fernández - alu0101686400@ull.edu.es


### 1 - Crea un script asociado al cubo que inicialice un array a un conjunto de valores numéricos aleatorios entre 0 y 25. En cada frame se debe cambiar una posición aleatoria y mostrar en pantalla en la consola los que sean mayores que 15. Parametrizar el rango para poderlo cambiar desde el inspector. 

![p2_1](https://github.com/adriansanzzzz/II_Actividad2/assets/74414073/9f06d255-ccc4-430b-b70d-f3be1e4365fa)




<img width="964" alt="image" src="https://github.com/adriansanzzzz/II_Actividad2/assets/74414073/3c383297-319d-4fac-ad53-e123f707aae9">
```csharp
public class p2_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string nombreObjeto = gameObject.name;
        Debug.Log("Nombre del objeto: " + nombreObjeto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
```
