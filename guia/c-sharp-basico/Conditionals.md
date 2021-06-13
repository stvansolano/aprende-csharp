Tutorial
--------
C# usa variables booleanas para evaluar condiciones. Los valores booleanos `true` y` false` se devuelven cuando se compara o eval�a una expresi�n.
Por ejemplo:

    int a = 4;
    bool b = a == 4;

    if (b) {
        Console.WriteLine("Es verdadero!");
    }

Por supuesto, normalmente no asignamos una expresi�n condicional a un bool, solo usamos la versi�n corta:

    int a = 4;

    if (a == 4) {
        Console.WriteLine("Ohhh! So a is 4!");
    }

### Operadores booleanos

No hay muchos operadores para usar en sentencias condicionales y la mayor�a de ellos son bastante simples:

    int a = 4;
    int b = 5;
    bool result;
    result = a < b; // true
    result = a > b; // false
    result = a <= 4; // menor o igual a 4- true
    result = b >= 6;
    result = a == b;
    result = a != b;
    result = a > b || a < b;
    result = 3 < a && a < 6;
    result = !result;

### Sentencias if - else

La sentencia if, else en C # es bastante simple.

    if (a == b) {
        // Tanto a como b son iguales, se ejecuta el codigo
    }

Y tambi�n podemos agregar una declaraci�n else despu�s de un if, para hacer algo si la condici�n no es verdadera

    if (a == b) {
        // Se ejecuta el codigo
    } else {
        // En caso de que no sea asi... :/
    }

Las declaraciones if - else no tienen que estar en varias l�neas con {}, si se pueden usar en una l�nea, o sin {}, para una declaraci�n de una sola l�nea.

    if (a == b)
        Console.WriteLine(Es verdadero!");
    else
        Console.WriteLine("Es falso!");

Although this method might be useful for making your code shorter by using fewer lines, we strongly recommend for beginners not to use this short version of statements and always use the full version with {}. This goes to every statement that can be shorted to a single line (for, while, etc).

Ejercicio
--------

En este ejercicio, debe construir una declaraci�n `if` que compruebe si el n�mero `adivinanza` es igual a 500. Si ese es el caso, Mostrar el mensaje `"��xito! "`.

C�digo del Tutorial
-------------

    using System;
    
    public class Conditionals
    {
        public static void Main()
        {
            int guess = 500;
            
            // Write conditional here
        }
    }

Salida Esperada
---------------

    ��xito, adivinaste!

Solucion
--------

    //