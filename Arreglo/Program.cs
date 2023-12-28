using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool llenado = true;
                Console.WriteLine("GRUPO SAMBORNS");
                Console.WriteLine("Ingresa la cantidad de numeros a ingresar: ");
                int longitud = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (longitud >= 10)
                {
                    int[] numeros = new int[longitud];

                    for (int i = 0; i < numeros.Length; i++)
                    {
                        Console.WriteLine("Ingresa el elemento " + (i + 1) + " del arreglo");
                        int numero = int.Parse(Console.ReadLine());

                        if (numero >= -15000 && numero <= 36500)
                        {
                            numeros[i] = numero;
                        }
                        else
                        {
                            Console.WriteLine("Numeros validos solo en el rango de: -15000 a 36500");
                            llenado = false;
                            break;
                        }
                    }

                    if (llenado == true)
                    {
                        if (numeros != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine("RESULTADOS");
                            Operaciones operaciones = new Operaciones(); // Creación de objeto
                            operaciones.promedio = Operaciones.Promedio(numeros);
                            Console.WriteLine("El promedio o media es: " + operaciones.promedio);
                            Console.WriteLine();
                            operaciones.sumatoria = Operaciones.Sumatoria(numeros, numeros.Length);
                            Console.WriteLine("La sumatoria total es: " + operaciones.sumatoria);
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Operación Finalizada ....");
                    }
                }
                else
                {
                    Console.WriteLine("La cantidad de numeros a ingresar debe ser por lo menos 10 o mas.");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine();
                Console.WriteLine("Para que todo funcione bien ingresar numeros enteros: \n\n" + ex);
            }

            Console.ReadKey();
        }
    }
}
