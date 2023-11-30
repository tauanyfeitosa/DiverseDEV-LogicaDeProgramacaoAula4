
namespace LogicaMatematica
{
    internal class Exercicio4
    {
        internal static void Executar4()
        {
            int[] A = new int[10];
            int[] B = new int[10];

            PreencherVetor("A", A);
            PreencherVetor("B", B);

            int[] C = CalcularSomaElementos(A, B);

            ExibirVetor("A", A);
            ExibirVetor("B", B);
            ExibirVetor("C (soma dos elementos de A e B)", C);
        }

        static void PreencherVetor(string nomeVetor, int[] vetor)
        {
            Console.WriteLine($"Digite os 10 elementos do vetor {nomeVetor}:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vetor[i] = ObterNumeroInteiro();
            }
        }

        static int[] CalcularSomaElementos(int[] vetorA, int[] vetorB)
        {
            int[] resultado = new int[10];
            for (int i = 0; i < 10; i++)
            {
                resultado[i] = vetorA[i] + vetorB[9 - i];
            }
            return resultado;
        }

        static void ExibirVetor(string nomeVetor, int[] vetor)
        {
            Console.WriteLine($"\nVetor {nomeVetor}:");
            foreach (var elemento in vetor)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }

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
