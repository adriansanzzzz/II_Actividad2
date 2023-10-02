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
#### - La magnitud de cada uno de ellos. 
#### - El ángulo que forman
#### - La distancia entre ambos.
#### - Un mensaje indicando qué vector está a una altura mayor.

