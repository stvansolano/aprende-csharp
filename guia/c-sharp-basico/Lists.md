Tutorial
--------

Las listas en C# realizan el mismo concepto que en otros lenguajes de programación. Una lista es un objeto que contiene variables en un orden específico.

El tipo de variable lista puede almacenar datos mediante la sintaxis genérica. Aquí hay un ejemplo de una lista llamada `números` que contiene números enteros:

    List<int> numbers = new List<int>();

La diferencia entre una lista y un arreglo/mariz es que las listas tienen un tamaño dinámico, mientras que los arreglos/matrices tienen un tamaño fijo. 

Cuando no sabe la cantidad de variables que su matriz debería contener, es mejor usar una lista.

Una vez que se inicializa la lista, podemos comenzar a insertar números en la lista.

    List<int> numbers = new List<int>();
    numbers.Add(1);
    numbers.Add(2);
    numbers.Add(3);

También podemos agregar un arreglo completo a una lista usando la función `AddRange`:

    List<int> numbers = new List<int>();
    int[] array = new int[] { 1, 2, 3 };
    numbers.AddRange(array);

### Remover de una lista

Podemos usar `Remove` para eliminar un elemento de una lista especificando el elemento que queremos eliminar.

    List<string> fruits = new List<string>();
    
    fruits.Add("apple");
    fruits.Add("banana");
    fruits.Add("orange");

    fruits.Remove("banana");
    Console.WriteLine(fruits.Count);

También podemos usar `RemoveAt` para especificar un índice de un elemento para eliminar. En nuestro caso, eliminar.

Utilizaremos el índice 1.

    List<string> fruits = new List<string>();
    // add fruits
    fruits.Add("apple"); // 0
    fruits.Add("banana"); // 1
    fruits.Add("orange"); // 2

    fruits.RemoveAt(1);
    Console.WriteLine(fruits.Count);

### Concatenar (Unir) listas

Podemos usar `AddRange` para unirnos entre listas:

    List<string> food = new List<string>();
    food.Add("apple");
    food.Add("banana");

    List<string> vegetables = new List<string>();
    vegetables.Add("tomato");
    vegetables.Add("carrot");

    food.AddRange(vegetables);
    Console.WriteLine(food.Count);

Ejercicio
--------

Construir una lista de los primeros 5 números primos (2, 3, 5, 7, 11).

Salida Esperada
---------------

    5
    2
    3
    5
    7
    11

Solucion
--------

    using System;
    using System.Collections.Generic;

    public class Hello
    {
        public static void Main()
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(2);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            primeNumbers.Add(11);

            // test code
            Console.WriteLine(primeNumbers.Count);
            Console.WriteLine(primeNumbers[0]);
            Console.WriteLine(primeNumbers[1]);
            Console.WriteLine(primeNumbers[2]);
            Console.WriteLine(primeNumbers[3]);
            Console.WriteLine(primeNumbers[4]);
        }
    }
