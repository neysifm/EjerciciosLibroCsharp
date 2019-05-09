using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01.Capitulo03
{
    class Ejercicios_1_4_y_5
    {
        public static void Ejercicio01()
        {
            int numero;
            Console.WriteLine("Introduzca un Numero entero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if ((numero % 2) == 0)
            {
                Console.WriteLine("El numero {0} es par", numero);
            }
            else
            {
                Console.WriteLine("El numero {0} es impar", numero);
            }
        }

        public static void Ejercicio04()
        {
            int numero;
            Console.WriteLine("Dias de semana: ");
            numero = Convert.ToInt32(Console.ReadLine());
            switch (numero)
            {
                case 1 + (int)DayOfWeek.Sunday:
                    Console.WriteLine("Domingo");
                    break;
                case 1 + (int)DayOfWeek.Monday:
                    Console.WriteLine("Lunes");
                    break;
                case 1 + (int)DayOfWeek.Tuesday:
                    Console.WriteLine("Martes");
                    break;
                case 1 + (int)DayOfWeek.Wednesday:
                    Console.WriteLine("Miercoles");
                    break;
                case 1 + (int)DayOfWeek.Thursday:
                    Console.WriteLine("Jueves");
                    break;
                case 1 + (int)DayOfWeek.Friday:
                    Console.WriteLine("Viernes");
                    break;
                case 1 + (int)DayOfWeek.Saturday:
                    Console.WriteLine("Sabado");
                    break;
                default:
                    Console.WriteLine("Numero de semana Incorrecto!!");
                    break;
            }
        }

        public static void Ejercicio05()
        {
            Console.WriteLine("1. Calcular Area || 2. Calcular Perimetro");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Cantidad de Lados: ");
                    int numeroLado = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Longitud de Lado: ");
                    float longitud = Convert.ToSingle(Console.ReadLine());
                    double perimetro = longitud * numeroLado;
                    Console.WriteLine("Perimetro: {0}", perimetro);
                    break;
                case 2:
                    Console.WriteLine("Perimetro: ");
                    perimetro = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Apotema: ");
                    float apotema = Convert.ToSingle(Console.ReadLine());
                    double area = apotema * perimetro;
                    Console.WriteLine("Area: {0}", area);
                    break;
            }
        }
    }
}
