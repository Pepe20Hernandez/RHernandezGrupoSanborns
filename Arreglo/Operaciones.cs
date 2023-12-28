using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo
{
    public class Operaciones
    {
        // atributos

        public float promedio;
        public float sumatoria;

        public static float Promedio(int[] arreglo) //Promedio o moda
        {
            float promedio;

            //for (int i = 0; i < arreglo.Length; i++)
            //{
            //    promedio += arreglo[i];
            //}

            promedio = Sumatoria(arreglo, arreglo.Length);

            promedio /= arreglo.Length;

            return promedio;

        }

        public static float Sumatoria(int[] arreglo, int tamaño) //Sumatoria total
        {
            float sumatoria = 0;

            if (tamaño == 0)
            {
                return sumatoria;
            }
            else
            {
                return arreglo[tamaño - 1] + Sumatoria(arreglo, tamaño - 1);
            }

        }
    }
}
