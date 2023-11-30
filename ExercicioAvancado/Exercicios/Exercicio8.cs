namespace ExercicioAvancado.Exercicios
{
    internal class Exercicio8
    {
        internal static void Main()
        {
            // Solicita ao usuário o tamanho do array
            Console.WriteLine("Digite o tamanho do array:");
            int tamanho = ObterNumeroInteiro();

            // Cria um array de inteiros com o tamanho fornecido pelo usuário
            int[] array = new int[tamanho];

            // Preenche o array com os elementos fornecidos pelo usuário
            PreencherArray(array);

            // Exibe o array original
            Console.WriteLine("\nArray original:");
            MostrarArray(array);

            // Aplica o algoritmo de Merge Sort para ordenar o array
            MergeSort(array);

            // Exibe o array ordenado
            Console.WriteLine("\nArray ordenado:");
            MostrarArray(array);
        }

        // Preenche o array com elementos fornecidos pelo usuário
        private static void PreencherArray(int[] array)
        {
            Console.WriteLine($"Digite os {array.Length} elementos do array (separados por espaço):");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ObterNumeroInteiro();
            }
        }

        // Algoritmo de Merge Sort
        private static void MergeSort(int[] array)
        {
            // Se o array tiver um elemento ou nenhum, já está ordenado
            if (array.Length <= 1)
                return;

            // Divide o array ao meio
            int meio = array.Length / 2;
            int[] esquerda = new int[meio];
            int[] direita = new int[array.Length - meio];

            // Copia os elementos para os arrays esquerda e direita
            Array.Copy(array, 0, esquerda, 0, meio);
            Array.Copy(array, meio, direita, 0, array.Length - meio);

            // Aplica o MergeSort recursivamente em cada metade
            MergeSort(esquerda);
            MergeSort(direita);

            // Combina as duas metades ordenadas
            Merge(array, esquerda, direita);
        }

        // Combina duas metades ordenadas em um único array ordenado
        private static void Merge(int[] array, int[] esquerda, int[] direita)
        {
            int i = 0, j = 0, k = 0;

            // Compara os elementos das duas metades e os mescla em ordem
            while (i < esquerda.Length && j < direita.Length)
            {
                if (esquerda[i] < direita[j])
                {
                    array[k] = esquerda[i];
                    i++;
                }
                else
                {
                    array[k] = direita[j];
                    j++;
                }
                k++;
            }

            // Adiciona os elementos restantes da metade esquerda (se houver)
            while (i < esquerda.Length)
            {
                array[k] = esquerda[i];
                i++;
                k++;
            }

            // Adiciona os elementos restantes da metade direita (se houver)
            while (j < direita.Length)
            {
                array[k] = direita[j];
                j++;
                k++;
            }
        }

        // Exibe os elementos do array
        private static void MostrarArray(int[] array)
        {
            foreach (var elemento in array)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }

        // Solicita ao usuário um número inteiro
        private static int ObterNumeroInteiro()
        {
            int numero;

            // Continua solicitando até que um número inteiro válido seja fornecido
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Digite um número inteiro válido!");
            }

            return numero;
        }
    }
}
