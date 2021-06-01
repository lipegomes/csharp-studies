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


            Product car = new Product(1, "Volvo S60", 38950, EProductType.Product);
            Product automotiveMechanics = new Product(2, "Engine repair", 2000, EProductType.Service);

            Console.WriteLine(car.Id);
            Console.WriteLine(car.Name);
            Console.WriteLine(car.Price);
            Console.WriteLine(car.Type);
            Console.WriteLine(automotiveMechanics.Id);
            Console.WriteLine(automotiveMechanics.Name);
            Console.WriteLine(automotiveMechanics.Price);
            Console.WriteLine(automotiveMechanics.Type);

            // strings

            //guids
            var id = Guid.NewGuid();
            id = new Guid("a7bb5045-f6d4-45d6-be10-e7f504437599");
            Console.WriteLine(id.ToString().Substring(0, 8));

            // interpolação de strings
            var price = 3.75;
            var texto = "A passagem de ônibus custa R$" + price;
            Console.WriteLine(texto);

            var texto2 = string.Format("O preço da gasolina é R${0} no dia sem imposto.", price);
            Console.WriteLine(texto2);

            // Datas
            var data = new DateTime();
            Console.WriteLine(data);

            var dataAtual = DateTime.Now;
            Console.WriteLine(dataAtual);

            // Array
            var cidades = new string[5];
            cidades[0] = "Rio de Janeiro";
            cidades[1] = "São Paulo";
            cidades[2] = "Curitiba";
            cidades[3] = "Florianópolis";
            cidades[4] = "Porto Alegre";

            Console.WriteLine(cidades[0]);
            Console.WriteLine(cidades[1]);
            Console.WriteLine(cidades[2]);
            Console.WriteLine(cidades[3]);
            Console.WriteLine(cidades[4]);

            var numeros = new int[3] { 100, 34, 30 };
            Console.WriteLine(numeros);

            // percorrendo o array
            // var numerosAteDez = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // for (var index = 0; index <= numerosAteDez.Length; index++)
            // {
            //     Console.WriteLine(numerosAteDez[index]);
            // }

            // percorrendo com ForEach
            var funcionarios = new Funcionario[10];
            funcionarios[0] = new Funcionario() { Id = 1288, Nome = "Monkey D. Luffy" };
            funcionarios[1] = new Funcionario() { Id = 826, Nome = "Roronoa Zoro" };
            funcionarios[2] = new Funcionario() { Id = 1029, Nome = "Nami" };
            funcionarios[3] = new Funcionario() { Id = 1456, Nome = "Usopp" };
            funcionarios[4] = new Funcionario() { Id = 977, Nome = "Sanji" };
            funcionarios[5] = new Funcionario() { Id = 1340, Nome = "Tony Tony Chopper" };
            funcionarios[6] = new Funcionario() { Id = 749, Nome = "Nico Robin" };
            funcionarios[7] = new Funcionario() { Id = 823, Nome = "Franky" };
            funcionarios[8] = new Funcionario() { Id = 21, Nome = "Brook" };
            funcionarios[9] = new Funcionario() { Id = 11, Nome = "Jimbei" };

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Nome);
            }

            // Exceptions
            var arr = new int[3];

            try
            {

                // for (var index = 0; index < 10; index++)
                // {
                //     // System.IndexOutOfRangeException
                //     Console.WriteLine(arr[index]);
                // }

                Cadastrar("");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);
                Console.WriteLine("Não encontrei o índice na lista!");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);
                Console.WriteLine("Falha ao cadastrar texto.");
            }
            catch (MinhaException e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.QuandoAconteceu);
                Console.WriteLine("Excessão customizada.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);
                Console.WriteLine("Ops, algo deu errado !!!");
            }
            finally
            {
                Console.WriteLine("Chegou ao fim !!!");
            }
        }

        static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new MinhaException(DateTime.Now);
            }
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu { get; set; }
        }
        static void MeuMetodo()
        {
            Console.WriteLine("Aprender C# é ao legal.");
        }

        static string RetornaNome(string nome, string sobrenome, int idade = 0)
        {
            if (nome == "Filipe")
            {
                return nome + " " + sobrenome + " tem " + idade.ToString() + " anos.";
            }
            else
            {
                return "Seu nome não é Filipe.";
            }
        }
    }



    // struct
    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double priceInDollar(double dollar)
        {
            return Price * dollar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }

    public struct Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
