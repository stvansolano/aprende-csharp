# Tutorial
--------

Los bucles For son muy similares a los bucles for en C, se definen así:

```
for( [variable contadora de iteraciones] ; [condicion a evaluar] ; [codigo a ejecutarse por iteracion])
{
    //
}
```

Ejemplo:

```
int i;

for( i = 0; i < 10; i++)
{
    //
}
```

Esto se repetirá hasta que ya no sea inferior a 10, aumentando `i` en 1 cada vez.
Sin embargo, a diferencia de C, C# le permite declarar la variable que está utilizando para contar las iteraciones en el bucle for:

    for( int i = 0; i < 10; i++)

Los bucles `For` se utilizan para permitirle repetir secciones de código una cantidad de veces fija o variable.

Esto le permite hacer su código más compacto y limpio.

Hay varias declaraciones que puede usar para controlar un ciclo:

    break;

Esto le permite salir de un bucle sin terminarlo.

Ejemplo

```
for(int i = 0; i < 16; i++)
{

    if(i == 12)
    {
        break;    
    }
}
```

Para terminar anticipadamente el bucle cuando el valor es 12 se utiliza el `break`, no cuando el bucle generalmente termine.

Para "saltar" o continuar o saltar a la siguiente iteracion, se utiliza `continue`.

Ejemplo:

```
for(int i = 0; i < 16; i++)
{
    if(i % 2 == 1)
    {
        continue;
    }

    Console.WriteLine(i);   
}
```

## Codigo del tutorial
-------------------

```

using System;

public class Functions
{
    public static void Main()
    {
        string x = "Hi";
        int n = 10;

        // Escribir el ciclo aca
    }

}
```

## Salida esperada
---------------

```

    Hola
    Hola
    Hola
    Hola
    Hola
    Hola
    Hola
    Hola
    Hola
    Hola
```

## Solucion
--------

```
using System;

public class Functions
{
    public static void Main()
    {
        string x = "Hi";
        int n = 10;

        for( int i = 0; i < n; i++)
        {
            Console.WriteLine(x);
        }
    }
}
```