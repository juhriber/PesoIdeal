using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            double pesoM;
            double pesoF;
            string sexo;

            Console.Write("Digite sua Altura: ");
            altura = double.Parse(Console.ReadLine());

            pesoM = altura * 72.7 - 58;
            pesoF = altura * 62.1 - 44.7;

            Console.Write("Digite seu sexo: ");
            sexo = Console.ReadLine();
            if (sexo == "M")
            {
                Console.WriteLine();
                Console.Write("Seu peso ideal é: ");
                Console.WriteLine($"{Math.Round(pesoM, 1)}kg");
                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
            }
            if (sexo == "Masculino")
            {
                Console.WriteLine();
                Console.Write("Seu peso ideal é: ");
                Console.WriteLine($"{Math.Round(pesoM, 1)}kg");
                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
            }
            if (sexo == "F")
            {
                Console.WriteLine();
                Console.Write("Seu peso ideal é: ");
                Console.WriteLine($"{Math.Round(pesoF, 1)}kg");
                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
            }
            if (sexo == "Feminino")
            {
                Console.WriteLine();
                Console.Write("Seu peso ideal é: ");
                Console.WriteLine($"{Math.Round(pesoF, 1)}kg");
                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
            }
        }
    }
}