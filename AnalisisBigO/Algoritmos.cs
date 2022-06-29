using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisBigO
{
    internal class Algoritmos
    {
        private const double PI = 3.141592653589793238462;

        public double ObtenerElAreaDeLaCircunferencia(int radio) // Entrada
        {
            double AreaDeLaCirunferencia = PI * (radio * radio); // Procesamiento
            return AreaDeLaCirunferencia; // Procesamiento
        }

        public int SumarDosNumeros(int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            return suma;
        }

        public bool EsNumeroPrimo(int numero)
        {
            return (numero % 2) == 0;
        }


        public double SumaYDivisionSumados(double numero1, double numero2)
        {
            //  Ver si es un número primo
            // 20 + 50 = 70
            // 20 / 50 = 0,4
            double resultadoSumado = numero1 + numero2;
            double elResultadoDividivo = numero1 / numero2; 
            return elResultadoDividivo + resultadoSumado;
        }

        public double SumaDivididoEntreDos(double numero1, double numero2)
        {
            double resultadoSumado = numero1 + numero2;
            double elResultadoDividido = resultadoSumado / 2;
            return elResultadoDividido;
        }


        public Resultado Multiplicatoria(int numero)
        {
            int resultado = 1;
            string valores = numero.ToString();
            for (int i = numero; i > 0; i--) //Cuidado con que i se nos haga Cero
            {
                resultado = resultado * i; // También se puede hacer resultado* = numero;
                if (i != numero)
                {
                    valores = valores + " * " + i.ToString();
                }
            }
            Resultado elResultado = new Resultado(resultado, valores);
            return elResultado;
        }


    }
}
