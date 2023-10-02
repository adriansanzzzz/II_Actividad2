# Práctica 2 - Introducción C# - Scripts
## Asignatura: Interfaces Inteligentes
## Adrián Sanz Fernández - alu0101686400@ull.edu.es


### 1 - Crea un script asociado al cubo que inicialice un array a un conjunto de valores numéricos aleatorios entre 0 y 25. En cada frame se debe cambiar una posición aleatoria y mostrar en pantalla en la consola los que sean mayores que 15. Parametrizar el rango para poderlo cambiar desde el inspector. 
He añadido el script p2_1 como componente al cubo.
Para que se pueda cambiar desde el inspector he definido como public los dos valores.
```csharp
public int minValue = 0;   
public int maxValue = 25;
```
```csharp
randomArray[i] = Random.Range(minValue, maxValue + 1); // Numeros aleatorios entre 0 y 25, +1 para que incluya el 25.
```

![p2_1](https://github.com/adriansanzzzz/II_Actividad2/assets/74414073/9f06d255-ccc4-430b-b70d-f3be1e4365fa)


### 2 - Crea una escena simple en la que ubiques un plano y sobre él un cubo, una esfera y un cilindro. Cada uno de los objetos debe estar en un color diferente. En la consola cada objeto debe mostrar su nombre.
 He añadido el script p2_2 como componente a cada objeto.

<img width="964" alt="image" src="https://github.com/adriansanzzzz/II_Actividad2/assets/74414073/3c383297-319d-4fac-ad53-e123f707aae9">

### 3 - Crea un script asociado a la esfera con dos variables Vector3 públicas. Dale valor a cada componente de los vectores desde el inspector. Muestra en la consola:
Declaro los vectores publicos
```csharp
public Vector3 vectorA;
public Vector3 vectorB;
```
#### - La magnitud de cada uno de ellos. 
Busque en la documentacion de Vector3 la propiedad de magnitud
https://docs.unity3d.com/ScriptReference/Vector3-magnitude.html
```csharp
float magnitudeA = vectorA.magnitude;
float magnitudeB = vectorB.magnitude;
```
#### - El ángulo que forman
https://docs.unity3d.com/ScriptReference/Vector3.Angle.html
```csharp
float angleDegrees = Vector3.Angle(vectorA, vectorB);
```
#### - La distancia entre ambos.
https://docs.unity3d.com/ScriptReference/Vector3.Distance.html
```csharp
float distance = Vector3.Distance(vectorA, vectorB);
```
#### - Un mensaje indicando qué vector está a una altura mayor.
Para ello hice un condicional que comprueba los distintos casos.

![p2_3](https://github.com/adriansanzzzz/II_Actividad2/assets/74414073/3107fa87-0ac3-4967-8017-e19459053bd0)

### 4- Muestra en pantalla el vector con la posición de la esfera.
<img width="1258" alt="image" src="https://github.com/adriansanzzzz/II_Actividad2/assets/74414073/09bf6b58-d18b-4626-8df9-28378447f807">

### 5 - Crea un script para la esfera que muestre en consola la distancia a la que están el cubo y el cilindro.
Primeramente, creo tags para cada objeto para poder asignarlos. <br>
<img width="200" alt="image" src="https://github.com/adriansanzzzz/II_Actividad2/assets/74414073/a51a6881-2cd5-43c5-bac6-5dbdff8ddcc5">
<img width="200" alt="image" src="https://github.com/adriansanzzzz/II_Actividad2/assets/74414073/dd42c0a8-7102-4a12-8769-f42cfa826601">
<br> He hecho public los tags para poder modificarlos desde el inspector. <br>
<img width="317" alt="image" src="https://github.com/adriansanzzzz/II_Actividad2/assets/74414073/d16413e2-50e8-4e2e-8f53-34966142ef10">
<img width="832" alt="image" src="https://github.com/adriansanzzzz/II_Actividad2/assets/74414073/366593ef-777f-4a00-b18e-695ca0506ede">

### 6 - Crea un script que alinee el cilindro y el cubo con la esfera, 5  unidades a derecha e izquierda respectivamente en el eje X. Prueba a cambiar a cambiar la coordenada x de la posición de la esfera en el Inspector de Objetos.
Busco por tags, creo un vector3 nuevo para el cilindro y el cubo y le aplico la posicion x de la esfera para estar alineados a esta.
Sumo y resto 5.0 para que se desplace a la derecha e izquierda.
Cuando cambio la X de la esfera, se desplaza todo en el eje x, ya que esta puesto dentro del update y cada frame cambia.
![p2_6](https://github.com/adriansanzzzz/II_Actividad2/assets/74414073/6105196e-61e9-43f6-9251-249bef4877cf)

### 7 - Cambia el color del cilindro cuando el usuario pulse la tecla A, cambia el color del cubo cuando el usuario pulse la flecha arriba.
Seguimos los pasos del enunciado para acceder a las propiedades de los materiales.
```csharp
 // Obtiene los materiales de los objetos cilindro y cubo
        cilindroMaterial = cilindro.GetComponent<Renderer>().material;
        cuboMaterial = cubo.GetComponent<Renderer>().material;
```
```csharp

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
        
```
![p2_7](https://github.com/adriansanzzzz/II_Actividad2/assets/74414073/17dc0d1a-5ed2-4afa-b30c-34e99f3b1f54)
### 8 - Agrega 5 esferas más en la escena. Crea un grupo de 2 , asígnales la misma etiqueta y a las restantes otra etiqueta diferente a ésta. Crea un vector con las distancias de cada una de las del segundo grupo al cubo. Sube en altura (aumenta la y) de la esfera más cercana. Cambiar color de la más lejana cuando el jugador pulsa la tecla espacio.
Añado esferas mediante
1. `GameObject`.
3. `3D Object`.
4. `Esfera`.
Creo un nuevo grupo y les asigno el tag first_blue_esfera.
<img width="1260" alt="image" src="https://github.com/adriansanzzzz/II_Actividad2/assets/74414073/5e188711-1f5c-4deb-a98b-c3f4993aaf04">
El resto que no estan en el grupo tienen el tag blue_esfera.

Hago un array con las esferas con cada tag diferente y el cubo.
```csharp
GameObject[] esferas = GameObject.FindGameObjectsWithTag(esferaTag);
GameObject[] esferas_sec = GameObject.FindGameObjectsWithTag(esfera_groupTag);
GameObject cubo = GameObject.FindWithTag(cuboTag);
```

Recorro la el array de esferas y guardo al final la esfera con menor distancia al cubo.
```csharp
foreach (GameObject esfera in esferas)
        {
            var distanceToCubo = Vector3.Distance(cubo.transform.position, esfera.transform.position);

            if (distanceToCubo < distanciaMinima)
            {
                distanciaMinima = distanceToCubo;
                esferaMasCercanaAlCubo = esfera;
            }
        }
```
Como en apartados anteriores, creo un vector con la nueva posición y se la cambio a la esfera más cercana.
```csharp
Vector3 min_newPositionEsfera = new Vector3(esferaMasCercanaAlCubo.transform.position.x, esferaMasCercanaAlCubo.transform.position.y + 1.0f,esferaMasCercanaAlCubo.transform.position.z);
esferaMasCercanaAlCubo.transform.position = min_newPositionEsfera;
```
Lo pongo en el start para que lo haga al inciar.

Repetimos lo mismo pero al contrario para obtener la esfera mas lejana.
```csharp
  if (Input.GetKeyDown(KeyCode.Space))
        {
            esferaMaterial = esferaMasLejanaCubo.GetComponent<Renderer>().material;
            esferaMaterial.color = Color.green;
        }
```
Esta vez dentro del update para que se accione al tocar el espacio.
![p2_8](https://github.com/adriansanzzzz/II_Actividad2/assets/74414073/6a2f0285-9490-43c6-b567-bcae610ba47c)
