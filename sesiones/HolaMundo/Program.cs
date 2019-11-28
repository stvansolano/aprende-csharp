using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            var nombre = "Esteban";
            var salario = 1234.88;
            var esCierto = true; // es true o false

            const int cuatro = 4;
            const string SR = "Sr.";

            int entero = 4;

            double precio = 124.65421212121221212;
            float precio2 = 1234.56f;
            decimal precio3 = 12345678910.00m;

            char caracter = 'd';
            double suma = 1 + 1; // 2

            Console.WriteLine("hola mundo!" + SR + nombre);
            Console.WriteLine("La suma es: " + suma.ToString());

            // Re-escribir el resultado
            suma = suma * 0.13; // 0.26
            Console.WriteLine("La suma es: " + suma.ToString());

            suma = suma + 0; // 0.26
            var sufijo = suma++; // suma = suma + 1
            Console.WriteLine("El sufijo es (antes): " + sufijo.ToString());
            Console.WriteLine("La suma es (despues): " + suma.ToString());

            Console.Read();
        }
    }
}
