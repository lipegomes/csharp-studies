// Importações
using System;

// Namespace
namespace MeuApp
{
    // Classe principal do programa
    class Program
    {
        // Função principal do programa
        static void Main(string[] args)
        {

            /*
            Comentário
            usando mais
            de uma linha
            */

            var anime = "Kingdom";
            int idade;
            idade = 2000;
            const int IDADE_MINIMA = 18;

            byte meuByte = 127;

            float valorCasa = 300000f;
            double mediaNotas = 7.5;
            decimal gastoAnual = 45.000m;

            bool usuarioJaCadastrado = false;
            bool pagamentoRecebido = true;
            var usuarioExpirado = false;

            char primeiraLetraNome = 'F';
            var segundaLetraNome = 'I';

            // object é do tipo desconhecido e se pode passar qualquer informação
            object quantidade;
            quantidade = 4.7;
            quantidade = "100 kg";

            // todo tipo primitivo pode ser nullable desde que se use ?
            int? idadeAtual = null;

            int inteiro1 = int.Parse("100");

            int inteiro2 = Convert.ToInt32("200");

            int valor = 1000;
            float real = 75.5f;

            // conversão implicita
            real = valor;


            int valor2 = 125;
            float real2 = 89.21f;

            // conversão explicita
            valor2= (int)real2;

            // conversão de um int para String
            String valorReal = real2.ToString();
            inteiro2 = int.Parse(valorReal);

            inteiro1 = Convert.ToInt32(real);

            Console.WriteLine(anime);
            Console.WriteLine(idade);
            Console.WriteLine(IDADE_MINIMA);
            Console.WriteLine(meuByte);
            Console.WriteLine(valorCasa);
            Console.WriteLine(mediaNotas);
            Console.WriteLine(gastoAnual);
            Console.WriteLine(usuarioJaCadastrado);
            Console.WriteLine(pagamentoRecebido);
            Console.WriteLine(usuarioExpirado);
            Console.WriteLine(primeiraLetraNome);
            Console.WriteLine(segundaLetraNome);
            Console.WriteLine(quantidade);
            Console.WriteLine(idadeAtual);
            Console.WriteLine(inteiro1);
            Console.WriteLine(inteiro2);
            Console.WriteLine(real);
            Console.WriteLine(valor);
            Console.WriteLine(real2);
            Console.WriteLine(valor2);
            Console.WriteLine(valorReal);
            Console.WriteLine(inteiro1);
            Console.WriteLine(Convert.ToBoolean(255));
        }
    }
}
