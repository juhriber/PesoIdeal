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
            Console.WriteLine();

            if (sexo.ToUpper() == "M" || sexo.ToUpper() == "MASCULINO")
            {
                Console.Write("Seu peso ideal é: ");
                Console.WriteLine($"{Math.Round(pesoM, 1)}kg");
            }
            else if (sexo.ToUpper() == "F" || sexo.ToUpper() == "FEMININO")
            {
                Console.Write("Seu peso ideal é: ");
                Console.WriteLine($"{Math.Round(pesoF, 1)}kg");
            }
            else
            {
                Console.WriteLine("Seu sexo não foi identificado. Tente novamente.");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();
        }
    }
}
