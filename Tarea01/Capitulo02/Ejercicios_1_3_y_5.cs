using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01.Capitulo02
{
    class Ejercicios_1_3_y_5
    {
        public static void Ejercicio01()
        {
            float perimetro;
            float longitud;
            float nlados;
            Console.WriteLine("Numero de lados : ");
            nlados = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Logitud de lado : ");
            longitud = Convert.ToSingle(Console.ReadLine());
            perimetro = nlados = longitud;
            Console.WriteLine("Perimetro: {0}", perimetro);

        }

        public static void Ejercicio03()
        {
            float radianes, grados;
            Console.WriteLine("Grados: ");
            grados = Convert.ToSingle(Console.ReadLine());
            radianes = (Convert.ToSingle(Math.PI / 180)) * grados;
            Console.WriteLine("Radianes: {0}", radianes);
        }

        public static void Ejercicio05()
        {
            Console.WriteLine("Cantidad de dolares: ");
            double dolares = Convert.ToDouble(Console.ReadLine());
            double euro = 0.86f;
            double dolaresEuro = dolares * euro;
            Console.WriteLine("{0} dolares = {1} Euros", dolares, dolaresEuro);

        }
    }
}
