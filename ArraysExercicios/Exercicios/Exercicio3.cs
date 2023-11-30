namespace ArraysExercicios.Exercicios
{
    internal class Exercicio3
    {
        internal static void Executar3()
        {
            // Solicita ao usuário o tamanho do array
            Console.WriteLine("Digite o tamanho do array:");
            int tamanhoArray = ObterNumeroInteiro();

            // Cria um array de inteiros com o tamanho fornecido pelo usuário
            int[] array = new int[tamanhoArray];

            // Preenche o array com os elementos fornecidos pelo usuário
            Console.WriteLine($"Digite os {tamanhoArray} elementos do array (separados por espaço):");
            array = ConstruirArray(tamanhoArray);

            // Solicita ao usuário o elemento a ser buscado
            Console.WriteLine("Digite o elemento a ser buscado no array:");
            int elementoBuscado = ObterNumeroInteiro();

            // Chama a função BuscarElemento e exibe o resultado
            int posicaoEncontrada = BuscarElemento(array, elementoBuscado);

            if (posicaoEncontrada != -1)
            {
                Console.WriteLine($"O elemento {elementoBuscado} foi encontrado na posição {posicaoEncontrada} no array.");
            }
            else
            {
                Console.WriteLine($"O elemento {elementoBuscado} não foi encontrado no array.");
            }
        }

        // Função para buscar elemento em array
        static int BuscarElemento(int[] array, int elemento)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elemento)
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

        // Função para construir array a partir da entrada do usuário
        static int[] ConstruirArray(int tamanho)
        {
            int[] arrayExemplo = new int[tamanho];

            string[] strings;
            while (true)
            {
                strings = Console.ReadLine().Split(' ');

                if (strings.Length != tamanho || !ValidarEntradasNumericas(strings))
                {
                    Console.WriteLine("A entrada colocada não tem o tamanho indicado pelo usuário ou contém caracteres não numéricos. Repita o processo e coloque a entrada novamente.");
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < strings.Length; i++)
            {
                arrayExemplo[i] = int.Parse(strings[i]);
            }

            return arrayExemplo;
        }

        // Função para validar entradas como números
        static bool ValidarEntradasNumericas(string[] entradas)
        {
            foreach (var entrada in entradas)
            {
                if (!int.TryParse(entrada, out _))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
