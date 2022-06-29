using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisBigO
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Algoritmos algoritmos = new Algoritmos();
            int radio = 4; // Entrada
            double Area = algoritmos.ObtenerElAreaDeLaCircunferencia(radio);// Procesamiento
            Console.WriteLine("Se calcula el Area de la Circunferencia con Radio: " + radio); // Salida
            Console.WriteLine("El Area de la Circunferencia es igual a: "+ Area); // Salida : Notación O(1) Tiempo Constante

            int numero1 = 20, numero2 = 50;
            int suma = algoritmos.SumarDosNumeros(numero1, numero2); // Notación O(1)

            Console.WriteLine("La suma de los dos números es: " + suma); // Salida

            int numero = 10;
            bool esPrimo = algoritmos.EsNumeroPrimo(numero);
            if (esPrimo)
            {
                Console.WriteLine("El número " + numero + " es primo"); // Salida
            }
            else
            {
                Console.WriteLine("El número " + numero + " no es primo"); // Salida
            }

            numero1 = 20;
            numero2 = 50;
            double sumaYDivision = algoritmos.SumaYDivisionSumados(numero1, numero2);
            Console.WriteLine("La suma y división, ambos resultados sumados es: " + sumaYDivision); // Salida

            numero1 = 30;
            numero2 = 50;
            double sumaDivididoEntreDos = algoritmos.SumaDivididoEntreDos(numero1, numero2);
            Console.WriteLine("La suma de los números "+ numero1 +" + "+ numero2 + " dividido entre 2 es: " + sumaDivididoEntreDos); // Salida

            numero = 4; //Entrada
            Resultado multiplicatoria = algoritmos.Multiplicatoria(numero); // Procesamiento
            Console.WriteLine("La Multiplicatoria del "+ numero +" hasta llegar a 1 (Todos los números multiplicados) "+ multiplicatoria.LosValores
                                +" es: "+ multiplicatoria.elResultado); // Salida Notación O(n) Tiempo Lineal

            Console.ReadLine(); 

            //Análisis del Algoritmo de Insertion Sort 
            /*int [] arr = { 1, 2, 3 };  // O (1)

            for (int i = 1; i < arr.Length; i++)  // O (n)
            {
                int actual = arr[i];  // O (n)
                int j = i - 1;  // O (n)

                while (i >=0 && arr[j] > actual) // O (n2)
                {
                    arr[j+1] = arr[j];  // O (n2) 
                    j--; // O (n2)
                }
                arr[j+1] = actual; //(n)  
            }

            // 4n + 3n2 + 1 = (3n2)  = O(n2) = Tiempo Cuadrático Notación Big O = Peor de los casos

            // 3n2 + 4n + 1 = O(n2)*/
        }
    }
}
