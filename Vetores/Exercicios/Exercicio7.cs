namespace Vetores.Exercicios
{
    internal class Exercicio7
    {
        internal static void Main()
        {
            // Cria dois vetores A e B com 10 elementos cada
            int[] A = new int[10];
            int[] B = new int[10];

            // Preenche os vetores A e B
            PreencherVetor("A", A);
            PreencherVetor("B", B);

            // Calcula o vetor C (soma dos elementos de A e B)
            int[] C = CalcularSomaElementos(A, B);

            // Exibe os vetores A, B e C
            ExibirVetor("A", A);
            ExibirVetor("B", B);
            ExibirVetor("C (soma dos elementos de A e B)", C);
        }

        // Método para preencher um vetor com valores fornecidos pelo usuário
        private static void PreencherVetor(string nomeVetor, int[] vetor)
        {
            Console.WriteLine($"Digite os 10 elementos do vetor {nomeVetor}:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vetor[i] = ObterNumeroInteiro();
            }
        }

        // Método para calcular a soma dos elementos de dois vetores
        private static int[] CalcularSomaElementos(int[] vetorA, int[] vetorB)
        {
            int[] resultado = new int[10];

            // Percorre os elementos dos vetores A e B e calcula a soma
            for (int i = 0; i < 10; i++)
            {
                // Os elementos de B são percorridos em ordem inversa (B[9 - i])
                resultado[i] = vetorA[i] + vetorB[9 - i];
            }

            // Retorna o vetor resultante
            return resultado;
        }

        // Método para exibir os elementos de um vetor
        private static void ExibirVetor(string nomeVetor, int[] vetor)
        {
            Console.WriteLine($"\nVetor {nomeVetor}:");
            foreach (var elemento in vetor)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }

        // Método para obter um número inteiro do usuário
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
