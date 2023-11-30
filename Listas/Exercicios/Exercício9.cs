using System;
using System.Collections.Generic;

namespace Listas.Exercicios
{
    internal class Exercicio9
    {
        internal static void Main()
        {
            // Solicita ao usuário o tamanho do array
            Console.WriteLine("Digite o tamanho da lista:");
            int tamanhoLista = ObterNumeroInteiro();

            // Cria uma lista de inteiros
            List<int> lista = new List<int>();

            // Preenche a lista com os elementos fornecidos pelo usuário
            Console.WriteLine($"Digite os {tamanhoLista} elementos da lista (separados por espaço):");
            for (int i = 0; i < tamanhoLista; i++)
            {
                lista.Add(ObterNumeroInteiro());
            }

            // Solicita ao usuário o elemento a ser buscado
            Console.WriteLine("Digite o elemento a ser buscado na lista:");
            int elementoBuscado = ObterNumeroInteiro();

            // Chama a função BuscarElemento e exibe o resultado
            int posicaoEncontrada = BuscarElemento(lista, elementoBuscado);

            if (posicaoEncontrada != -1)
            {
                Console.WriteLine($"O elemento {elementoBuscado} foi encontrado na posição {posicaoEncontrada} na lista.");
            }
            else
            {
                Console.WriteLine($"O elemento {elementoBuscado} não foi encontrado na lista.");
            }
        }

        // Função para buscar elemento em lista
        static int BuscarElemento(List<int> lista, int elemento)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == elemento)
                {
                    return i;
                }
            }

            return -1;
        }

        // Função auxiliar para obter um número inteiro digitado pelo usuário
        static int ObterNumeroInteiro()
        {
            int numero;

            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Digite um número inteiro válido!");
            }

            return numero;
        }
    }
}
