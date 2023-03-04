using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Ejercicio 1");
            Console.Write("Ingrese un número entero: ");

            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x > 0)
                {
                    Console.WriteLine("Es un número entero positivo");
                }
                else if (x < 0)
                {
                    Console.WriteLine("Es un número entero negativo");
                }
                else
                {
                    Console.WriteLine("El número entero es igual a cero");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No ingreso un número. " + ex.Message);
            }
            Console.ReadKey();

            int dia;
            Console.WriteLine("\n" + "Ejercicio 2");
            Console.Write("Ingrese un número de día: ");
            dia = Convert.ToInt32(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("El número de día que ingreso es LUNES");
                    break;
                case 2:
                    Console.WriteLine("El número de día que ingreso es MARTES");
                    break;
                case 3:
                    Console.WriteLine("El número de día que ingreso es MIERCOLES");
                    break;
                case 4:
                    Console.WriteLine("El número de día que ingreso es JUEVES");
                    break;
                case 5:
                    Console.WriteLine("El número de día que ingreso es VIERNES");
                    break;
                case 6:
                    Console.WriteLine("El número de día que ingreso es SABADO");
                    break;
                case 7:
                    Console.WriteLine("El número de día que ingreso es DOMINGO");
                    break;
                default:
                    Console.WriteLine(dia + " no es un día valido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
