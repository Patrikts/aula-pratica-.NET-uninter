using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uninter_pratica_2
{
    public class PraticaComArrays
    {
        public void Exercicio1()
        {
            int[] arrayIntLinear = new int[100000];

            //populas as posições com seu valor de indice linearmente
            for (int i =0; i < 100000; i++)
            {
                arrayIntLinear[i] = i;
            }
            int[,] matriz = new int[100, 100];
            var rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                for (int k = 0; k < 100; k++)
                {
                    matriz[i, k] = rand.Next(1, 300000);
                }
            }

            int countMatch = 0;
            for (int i = 0; i < matriz.GetUpperBound(0); i++)
            {
                for (int k = 0; k < matriz.GetUpperBound(1); k++)
                {
                    var valorMatriz = (int)matriz.GetValue(i, k);

                    for (int x = 0; x < arrayIntLinear.Length; x++)
                    {
                        if (arrayIntLinear[x] == valorMatriz)
                        {
                            countMatch++;
                        }
                    }
                }
            }
            Console.WriteLine($"Houveram {countMatch} entre os valores randômicos da matriz e do array linear!");
        }

        public void Exercicio2(object arrayFinal)
        {
            Console.WriteLine("**************************************");

            //declarando arrays de base para o exercicio
            char[] alfabetoArray = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'W', 'X', 'Y', 'Z' };
            char[] arrayCharAleatorio = new char[100];
            Random rand = new Random();

            //populando o array aleatorio
            for (int i = 0; i < 100; i++)
            {
                arrayCharAleatorio[i] = alfabetoArray[rand.Next(0, alfabetoArray.Length)];
            }

            int posInicial = 0;
            int posFinal = 0;

            Console.WriteLine("Informe um valor inicial para recortar do array original:");
            posInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe um valor final (maior que o valor anterior) para recortar do array original:");
            posFinal = int.Parse(Console.ReadLine());

            for (int i = posInicial; i < posFinal; i++)
            {
                arrayFinal[i] = arrayCharAleatorio[i];
            }

            var stringFinal = new string(arrayFinal);

            Console.WriteLine("A string final ficou assim:");
            Console.WriteLine(stringFinal);
        }

    }

}






