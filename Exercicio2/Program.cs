using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // variavel pessoa
            dados X;
            dados Y;
 //==============================================================================
            // instanciar variavel
            X = new dados();
            Y = new dados();
 //==============================================================================
            // informação do primeiro usuario
            Console.WriteLine("coloque seu nome");
            X.N = Console.ReadLine();
            Console.WriteLine("coloque sua idade");
            X.I = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 //==============================================================================
            // informação do segundo usuario
            Console.WriteLine("coloque o nome da segunda pessoa");
            Y.N = Console.ReadLine();
            Console.WriteLine("coloque a idade da segunda pessoa");
            Y.I = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 //==============================================================================
            //parâmetro para ver a pessoa mais velha
            if (X.I >= Y.I)
            {
                Console.WriteLine("PESSOA MAIS VELHA " + X.N);
            }
            else
            {
                Console.WriteLine("PESSOA MAIS VELHA " + Y.N);
            }




        }
    }
}
