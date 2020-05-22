using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Você precisa calcular o índice de massa corporal?");

            Console.WriteLine(" pressione uma tecla para continuar...:");

            Console.ReadKey();



            Console.WriteLine("Informe o peso em kilo grama (Kg).");

            double peso = double.Parse(Console.ReadLine());



            Console.WriteLine("Informe a altura em metros (M)");

            double altura = double.Parse(Console.ReadLine());



            Console.Write("O IMC é: ");

            double resultado = Math.Pow(altura, 2);

            double resultado2 = (peso / resultado );



            Console.Write( resultado2);

            Console.WriteLine(" kg/m².");



            Console.ReadKey();
        }
    }
}
