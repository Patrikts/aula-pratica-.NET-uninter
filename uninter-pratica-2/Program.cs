using System;
using uninter_pratica_2;

namespace ConsoleApp.AulaPraticaGrav2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula Prática de C# 2!");
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Arrays");
            Console.WriteLine("------------------------------");
            PraticaComArrays praticaComArrays = new PraticaComArrays();
            praticaComArrays.Exercicio1();
            praticaComArrays.Exercicio2();

        }
    }
}