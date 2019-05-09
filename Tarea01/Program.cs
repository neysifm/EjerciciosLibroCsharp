using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea01.Capitulo01;
using Tarea01.Capitulo02;
using Tarea01.Capitulo03;
using Tarea01.Capitulo04;

namespace Tarea01
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Capitulo 01 = Ejercicio 01");
                Console.WriteLine("2. Capitulo 01 = Ejercicio 05");
                Console.WriteLine();
                Console.WriteLine("===================================================");
                Console.WriteLine();
                Console.WriteLine("3. Capitulo 02 = Ejercicio 01");
                Console.WriteLine("4. Capitulo 02 = Ejercicio 03");
                Console.WriteLine("5. Capitulo 02 = Ejercicio 05");
                Console.WriteLine();
                Console.WriteLine("===================================================");
                Console.WriteLine();
                Console.WriteLine("6. Capitulo 03 = Ejercicio 01");
                Console.WriteLine("7. Capitulo 03 = Ejercicio 04");
                Console.WriteLine("8. Capitulo 03 = Ejercicio 05");
                Console.WriteLine();
                Console.WriteLine("===================================================");
                Console.WriteLine();
                Console.WriteLine("9.  Capitulo 04 = Ejercicio 01");
                Console.WriteLine("10. Capitulo 04 = Ejercicio 02");
                Console.WriteLine("11. Capitulo 04 = Ejercicio 05");
                Console.WriteLine("12. Salir");
                Console.WriteLine();
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Ejercicios_1_y_5.Ejercicio01();
                        Console.ReadKey();
                        break;
                    case 2:
                        Ejercicios_1_y_5.Ejercicio05();
                        Console.ReadKey();
                        break;
                    case 3:
                        Ejercicios_1_3_y_5.Ejercicio01();
                        Console.ReadKey();
                        break;
                    case 4:
                        Ejercicios_1_3_y_5.Ejercicio03();
                        Console.ReadKey();
                        break;
                    case 5:
                        Ejercicios_1_3_y_5.Ejercicio05();
                        Console.ReadKey();
                        break;
                    case 6:
                        Ejercicios_1_4_y_5.Ejercicio01();
                        Console.ReadKey();
                        break;
                    case 7:
                        Ejercicios_1_4_y_5.Ejercicio04();
                        Console.ReadKey();
                        break;
                    case 8:
                        Ejercicios_1_4_y_5.Ejercicio05();
                        Console.ReadKey();
                        break;
                    case 9:
                        Ejercicios_1_2_y_5.Ejercicio01();
                        Console.ReadKey();
                        break;
                    case 10:
                        Ejercicios_1_2_y_5.Ejercicio02();
                        Console.ReadKey();
                        break;
                    case 11:
                        Ejercicios_1_2_y_5.Ejercicio05();
                        Console.ReadKey();
                        break;
                    case 12:        
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opcion != 12);
        }
    }
}
