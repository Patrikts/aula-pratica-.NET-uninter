using System;
using Uninter_1;

namespace ConsoleApp.Pratical
{

    class Program
    {
        char c1 = 'c';

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! - Aula Prática 1!");
            Console.WriteLine("--------------------------------");

            int int1 = 10;
            Console.Write($"{int1}");

            bool bool1 = true;
            bool bool2 = false;

            long long1 = 4324324234325325;
            decimal decimal1 = 123.234M;
            float f1 = 23123.123f;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Tipos reference types");

            object obj1 = new object();
            var obj2 = new object();

            var obj3 = obj2;

            Console.WriteLine("Comparando objs");
            Console.WriteLine($"{obj1.GetType().Name} | {obj2.GetType().Name} | {obj3.GetType().Name}");
            Console.WriteLine($"{obj2 == obj3}");

            Console.WriteLine("--------------------------------");

            var s1 = new string('a', 5);
            string s2 = new string(new char[5] { 'a', 'a', 'a', 'a', 'a' });

            Console.WriteLine($"{s1 == s2}");

            string s3 = string.Concat((new char[5] { 'a', 'a', 'a', 'a', 'a' }).AsEnumerable());
            var s4 = $"{s3} string 3";

            Console.WriteLine($"{s4.ToString()}");

            Console.WriteLine("--------------------------------");

            ClasseCompareString compare1 = new ClasseCompareString()
            {
                testeComparacao = "123"
            };
            var compare2 = new ClasseCompareString()
            {
                testeComparacao = "123"
            };

            Console.WriteLine($"Compare com == e com equals");

            Console.WriteLine($"{compare1 = compare2}");

            Console.WriteLine($"{compare1.testeComparacao = compare2.testeComparacao}");
            Console.WriteLine($"{compare1.testeComparacao.Equals(compare2.testeComparacao)}");

            Console.WriteLine("--------------------------------");

            ClasseComplexa classeComplexa = new ClasseComplexa();
            classeComplexa.PropInterface = "123";

            IImprimirValores interfaceX = classeComplexa;

            Console.WriteLine($"{interfaceX.PropInterface}");

            /*------------------------------------------------------*/
            //Divisor
            /*------------------------------------------------------*/

            Console.WriteLine("--------------------------------");

            IDivisor divisorCalculadora = new DivisorCalc();

            Console.WriteLine("Digite 'S' para Sair a qualquer momento");
            string valorLido = string.Empty;
            int a;
            int b;
            string valorSaida = "S";
            do
            {
                //A

                Console.WriteLine("Digite o valor A:");

                valorLido = Console.ReadLine();
                if (valorSaida.Equals(valorLido))
                    break;
                try
                {
                    a = int.Parse(valorLido);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao converter o valor lido para int. Valor: {valorLido}. Erro: {ex.Message}");
                    continue;
                }

                //B

                Console.WriteLine("Digite o valor A:");

                valorLido = Console.ReadLine();
                if (valorSaida.Equals(valorLido))
                    break;
                try
                {
                    b = int.Parse(valorLido);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao converter o valor lido para int. Valor: {valorLido}. Erro: {ex.Message}");
                    continue;
                }

                try
                {
                    var resultado = divisorCalculadora.Dividir(a, b);
                    Console.WriteLine("Resultado:");
                    Console.WriteLine(resultado);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Divisão por zero detectada. Reiniciando processo");
                }

            } while (valorSaida.Equals(valorLido) == false);

            Console.WriteLine(divisorCalculadora.Dividir(100, 10));
            
        }
    }
}
