using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01.Capitulo04
{
    class Ejercicios_1_2_y_5
    {
        public static void Ejercicio01()
        {
            int numero;
            Console.WriteLine("Mostrar tabla del numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            int tabla;
            for (int i = 1; i <= 10; ++i)
            {
                tabla = numero * i;
                Console.WriteLine("{0} * {1} = {2}", numero, i, tabla);
            }
        }

        public static void Ejercicio02()
        {
            Console.WriteLine("Digite La Base: ");
            int baseNumerica = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite La Potencia: ");
            int potencia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} ^ {1} = {2}", baseNumerica, potencia, Convert.ToInt32(Math.Pow(baseNumerica, potencia)));
        }

        public static void Ejercicio05()
        {
            Console.WriteLine("Cantidad de personas: ");
            int nPersonas = Convert.ToInt32(Console.ReadLine());
            int edadMayor = Int32.MinValue;
            int edadMenor = Int32.MaxValue;
            int edad;
            for (int i = 0; i < nPersonas; i++)
            {
                Console.WriteLine("Edad de Persona: {0}", i + 1);
                edad = Convert.ToInt32(Console.ReadLine());
                if (edadMayor <= edad)
                    edadMayor = edad;
                if (edadMenor >= edad)
                    edadMenor = edad;
            }

            Console.WriteLine("La edad Mayor es: {0}", edadMayor);
            Console.WriteLine("La edad Menor es: {0}", edadMenor);
        }
    }
}
