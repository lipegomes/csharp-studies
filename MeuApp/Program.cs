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

            // object é do tipo desconhecido e se pode passar qualquer informação
            object quantidade;
            quantidade = 4.7;
            quantidade = "100 kg";
            Console.WriteLine(quantidade);

            // todo tipo primitivo pode ser nullable desde que se use ?
            int? idadeAtual = null;
            Console.WriteLine(idadeAtual);

            int inteiro1 = int.Parse("100");
            int inteiro2 = Convert.ToInt32("200");
            Console.WriteLine(inteiro1);
            Console.WriteLine(inteiro2);

            int valor = 1000;
            float real = 75.5f;
            Console.WriteLine(real);
            Console.WriteLine(valor);

            // conversão implicita
            real = valor;

            int valor2 = 125;
            float real2 = 89.21f;
            Console.WriteLine(real2);
            Console.WriteLine(valor2);

            // conversão explicita
            valor2 = (int)real2;

            // conversão de um int para String
            String valorReal = real2.ToString();
            Console.WriteLine(valorReal);

            inteiro1 = Convert.ToInt32(real);
            Console.WriteLine(inteiro1);

            Console.WriteLine(Convert.ToBoolean(255));

            // operações de atribuição
            int x = 0;

            x += 2;
            Console.WriteLine(x);

            x -= 26;
            Console.WriteLine(x);

            x *= 25;
            Console.WriteLine(x);

            x /= 30;
            Console.WriteLine(x);

            // operadores de comparação
            double y = 2;
            y = 369 / 21;
            Console.WriteLine(y);

            double z = 369;
            z *= 365;

            Console.WriteLine(z);

            double w = z;
            w = (w / 21) / 7;
            Console.WriteLine(w);

            int num1 = 2;
            num1++;
            Console.WriteLine(num1);

            int num2 = num1;
            num2--;
            Console.WriteLine(num2);

            Console.WriteLine(num2 == num1);
            Console.WriteLine(num2 != num1);
            Console.WriteLine(num2 > num1);
            Console.WriteLine(num2 < num1);
            Console.WriteLine(num2 >= num1);
            Console.WriteLine(num2 <= num1);

            // operadores lóogicos
            int total = 20;

            bool entre = (total > 50) && (total < 30); // False
            Console.WriteLine(entre);

            bool ou = (total > 14) || (total < 77); //True
            Console.WriteLine(ou);

            bool negacao = !(total < 20); // True
            Console.WriteLine(negacao);

            // operador condicinoal if
            int numeroDaCamisa = 10;

            if (numeroDaCamisa == 10)
            {
                Console.WriteLine("Você é o camisa 10 do time !!!");
            }
            else
            {
                Console.WriteLine("Se esforce mais, enxergue o seu objetivo e se torne o camisa 10 !!!");
            }

            Console.WriteLine("Camisa 10 finalizado.");

            int idadePessoa = 30;
            int maioridade = 21;

            if (idadePessoa >= maioridade)
            {
                Console.WriteLine("Permitido comprar bebidas alcoólicas.");
            }
            else
            {
                Console.WriteLine("Proibido a venda de bebidas alcoólicas para menores de 18 anos.");
            }

            Console.WriteLine("Open bar Finalizado.");

            // estrututal condicional: switch
            string meuNome = "Filipe";
            switch (meuNome)
            {
                case "Filipe": Console.WriteLine("Ganhou na loteria!"); break;
                case "Anna": Console.WriteLine("Desejo mais sorte em apostar!"); break;
                case "Dorota": Console.WriteLine("Desejo mais sorte em apostar!"); break;
                default: Console.WriteLine("O ganhador é um desconhecido."); break;
            }

            bool? brasileiro = true;
            switch (brasileiro)
            {
                case true: Console.WriteLine("É brasieleiro."); break;
                case false: Console.WriteLine("Não é brasileiro"); break;
                default: Console.WriteLine("Nulo"); break;
            }

            // laços de repetição: for
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // laços de repetição: while
            int num3 = 0;
            while (num3 <= 10)
            {
                num3++;
                Console.WriteLine(num3);
            }

            int num4 = 0;
            while (num4 >= 10)
            {
                num4--;
                Console.WriteLine(num4);
            }

            // laço de repetição: do
            float cotacaoDolarEmReais = 5.2281f;

            do
            {
                Console.WriteLine(cotacaoDolarEmReais);
                cotacaoDolarEmReais++;
            } while (cotacaoDolarEmReais <= 10);

            // funcões ou métodos
            MeuMetodo();

            string nomeSobrenome = RetornaNome("Filipe", "Gomes", 29);
            Console.WriteLine(nomeSobrenome);
        }

        static void MeuMetodo()
        {
            Console.WriteLine("Aprender C# é ao legal.");
        }

        static string RetornaNome(string nome, string sobrenome, int idade = 0)
        {
            if (nome == "Filipe")
            {
                return nome + " " + sobrenome+ " tem " + idade.ToString() + " anos.";
            }
            else
            {
                return "Seu nome não é Filipe.";
            }
        }
    }
}
