using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Escolha uma das operações matemáticas abaixo: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-----------------");
            Console.WriteLine("Digite uma opção(ex: 1): ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multipicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;

            }
        }

        // Método Soma
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("---- Soma ----");

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            // váriavel resultado armazena o resulado da soma
            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é {resultado}");

            Console.ReadKey();
            Menu();
        }

        // Método Subtração
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("---- Subtração ----");

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            // váriavel resultado armazena o resulado da subtração
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");

            Console.ReadKey();
            Menu();
        }

        // Método Divisão
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("---- Divisão ----");

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            // váriavel resultado armazena o resultado da divisão;
            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Multipicacao()
        {
            Console.Clear();

            Console.WriteLine("---- Multiplicação ----");

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            // váriavel resultado armazena o resultado da multiplicação;
            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");

            Console.ReadKey();
            Menu();
        }
    }
}
