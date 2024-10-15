using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class MinhaCalculadora
    {
        private int n1;
        private int n2;
        private int resultado;
        public int OperacaoEscolhida { get; set; }

        private void ReceberNumeros()
        {
            Console.WriteLine("Digite o 1º número: ");
            this.n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número: ");
            this.n2 = int.Parse(Console.ReadLine());
        }
        public void ExibirMenu()
        {
            Console.WriteLine("*** CALCULADORA ***");
            Console.WriteLine("Qual operação você deseja realizar? Escolha alguma das opções abaixo:");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Divisão");
            Console.WriteLine("4. Multiplicação");
            Console.WriteLine("5. Sair");

            string opcaoEscolhida = Console.ReadLine();

            switch (opcaoEscolhida) {
                case "1":
                    ReceberNumeros();
                    resultado = Soma(n1, n2);
                    ExibirResultado("Somatório", n1, n2, resultado);
                    break;
                case "2":
                    ReceberNumeros();
                    resultado = Subtracao(n1, n2);
                    ExibirResultado("Subtração", n1, n2, resultado);
                    break;
                case "3":
                    ReceberNumeros();
                    resultado = Divisao(n1, n2);
                    ExibirResultado("Divisão", n1, n2, resultado);
                    break;
                case "4":
                    ReceberNumeros();
                    resultado = Multiplicacao(n1, n2);
                    ExibirResultado("Multiplicação", n1, n2, resultado);
                    break;
                case "5":
                    Console.WriteLine("Encerrando a aplicação...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Por favor, tente novamente!");
                    ExibirMenu();
                    break;

            }
        }


        public int Soma(int n1, int n2)
        {
            return n1 + n2;
        }
        public int Subtracao(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Multiplicacao(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Divisao(int n1, int n2)
        {
            return n1 / n2;
        }

        public void ExibirResultado(string operacao, int n1, int n2, int resultado)
        {
            Console.WriteLine($"{operacao} de {n1} com {n2} é igual a {resultado}");
        }
    }
}
