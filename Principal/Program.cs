using System;

namespace Principal
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            while (true)
            {
                // Print para informações gerais
                Console.WriteLine("\nINICIANDO O PROGRAMA\n\n_______________________________________\n\n" +
                    "Este programa visa trabalhar com arrays, listas e laços. Abaixo, têm-se os exercícios aqui " +
                    "propostos:\n");

                // Array de strings para a lista de exercícios
                string[] exercicios = {
                    "1.1. Arrays: Exibir arrays de inteiros",
                    "1.2. Arrays: Principais métodos e propriedades",
                    "1.3. Arrays e Funções: Buscar elementos em um array",
                    "2.1. Lógica Matemática: Média, Soma e Menor",
                    "2.2. Lógica Matemática: Soma de números de 1 a 100",
                    "2.3. Lógica Matemática: Ler números até digitar 0",
                    "3.1. Vetores: arrays lineares",
                    "4.1. Exercício Avançado",
                    "5.1. Listas: Buscar elementos em uma lista",
                    "0. Sair"
                };

                // Chamada de método para obter a escolha do usuário
                int escolha = EscolhaUsuario(exercicios.Length, exercicios);

                // Saída do loop se o usuário escolher sair
                if (escolha == 0)
                {
                    break;
                }

                // Divisão de acordo com a escolha do usuário
                if (escolha >= 1 && escolha <= 3)
                {
                    ArraysExercicios.Program.MetodoPrincipal(escolha);
                }
                else if (escolha >= 4 && escolha <= 6)
                {
                    LogicaMat.Program.MetodoPrincipal(escolha);
                }
                else if (escolha == 7)
                {
                    Vetores.Program.MetodoPrincipal(escolha);
                }
                else if (escolha == 8)
                {
                    ExercicioAvancado.Program.MetodoPrincipal(escolha);
                }
                else if (escolha == 9)
                {
                    Listas.Program.MetodoPrincipal(escolha);
                }
            }
        }

        // Método para mostrar lista
        private static void MostrarLista(string[] exercicios)
        {
            Console.WriteLine("Escolha um dos exercícios abaixo:\n");

            foreach (string exercicio in exercicios)
            {
                Console.WriteLine($"{Array.IndexOf(exercicios, exercicio) + 1}. {exercicio}");
            }

            Console.WriteLine($"{exercicios.Length + 1}. Sair");
        }

        // Método de interação com o usuário para obter a escolha, travando para interações não
        // permitidas até que o usuário coloque uma escolha válida
        private static int EscolhaUsuario(int rangeExercicios, string[] exercicios)
        {
            int escolha;
            MostrarLista(exercicios);

            do
            {
                Console.WriteLine("\nDigite o número do exercício desejado:");
            } while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 0 || escolha > rangeExercicios + 1);

            return escolha;
        }
    }
}
