Tutorial
--------

C# es un lenguaje de programaci�n de que nos permite escribir c�digo que se ejecuta sobre el entorno .NET de Microsoft.
C# tiene m�s funciones y capacidades de otros lenguajes como Java y JavaScript, fue desarrollado por Microsoft y puede utilizarse
en diferentes entornos, ambientes y Sistemas Operativos.

C# est� orientado a objetos y su sintaxis es muy similar a otros lenguajes de alto nivel como Java, JavaScript, Python.

En este tutorial, usaremos la funci�n `System.Console.WriteLine` para escribir l�neas en la salida
consola. Al escribir una aplicaci�n de l�nea de comandos de C#, la misma funci�n tambi�n se puede utilizar para imprimir en la
consola.

** Nota: ** Es posible escribir aplicaciones web usando  # usando el entorno ASP.NET, Xamarin, entre otras.

Ejercicio
--------

Mostrar "Hola, Mundo!" en la consola.

C�digo del Tutorial
-------------

    using System;

    public class Hello
    {
        public static void Main()
        {
            System.Console.WriteLine("Adios, Mundo!");
        }
    }

Salida esperada
---------------

    Hola, Mundo!

Soluci�n
--------

using System;

namespace csharp_basico
{
    class Program
    {
        static public void Main(string[] args)
        {
            Console.Write("Hola, Mundo!");
            Console.Write("Haga enter para cerrar");

            Console.ReadKey();
        }
    }
}
