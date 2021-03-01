using System;

namespace Practica_cantidad_dias_por_mes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meses = new string[]
            {
                "Enero",
                "Febrero",
                "Marzo",
                "Abril",
                "Mayo",
                "Junio",
                "Julio",
                "Agosto",
                "Septiembre",
                "Octubre",
                "Noviembre",
                "Diciembre"
            };

            int[] cantidadDeDias = new int[]
            {
                31,28,31,30,31,30,31,31,30,31,30,31
            };

            
            Console.WriteLine("Meses del Año:");
            for (int i = 0; i < 12; i++)
            {
                int mes = i + 1;
                Console.WriteLine(mes+" - " +meses[i]);
            }
            Console.WriteLine("Seleccione un mes:");

            string valor = Console.ReadLine();
            int mesSeleccionado = int.Parse(valor);

            for (int i = 1; i <= 12; i++)
            {
                if (i == mesSeleccionado)
                {                    
                    Console.WriteLine("Cantidad de dias:"+ cantidadDeDias[i-1]);
                    break;
                }
            }
        }
    }
}
