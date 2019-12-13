using System;

namespace HolaMundo
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Condicionales");
            Console.WriteLine("Es usted estudiante?");

            var cadena = Console.ReadLine();

            Console.WriteLine("Usted escribio: " + cadena);

            // 1) Descarte
            // 2) funciones "string"
            // 3) Expresiones regulares o RegEx

            bool evaluacion = cadena == "si" // OR
                             || cadena.ToUpper() ==  "SI";

            if (evaluacion)
            {
                Console.WriteLine("Ud. es estudiante!");
            }
            else 
            {
                Console.WriteLine("Ud NO es estudiante");
            }

            Console.ReadLine();
        }
    }
}