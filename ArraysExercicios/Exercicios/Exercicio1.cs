namespace ArraysExercicios.Exercicios
{
    internal class Exercicio1
    {
        //Método principal que chama o método ImprimirArray - respon~sável por chamar os demais métodos
        internal static void Main()
        {
            Console.WriteLine("Neste exercício, iremos criar um array de inteiros! Todo array tem um tamanho pré-definido, " +
                "por isso, escolha primeiro o tamanho do seu array:\n");
            ImprimirArray();
        }

        //Método de interação com o usuário para obter o tamanho do array desejado
        private static int TamanhoArray()
        {
            int tamanho;
            do
            {
                Console.WriteLine("Digite o tamanho desejado para seu array:");
            } while (!int.TryParse(Console.ReadLine(), out tamanho));
            Console.WriteLine($"O tamanho escolhido foi {tamanho}. Digite agora, um após o outro, os números a serem inseridos no " +
                $"array. Os números devem ser inseridos na mesma linha, com um espaço entre eles.");
            return tamanho;
        }

        //Método para a construção do array a partir de uma entrada de números em uma única linha, separados por espaço
        //Este método chama o método ValidarEntradasNumericas para verificar a validade de caractere por caractere 
        private static int[] ConstruirArray(int tamanho)
        {
            int[] arrayExemplo = new int[tamanho];

            string[] strings;
            while (true)
            {
                strings = Console.ReadLine().Split(" ");

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
                arrayExemplo[i] = int.Parse(strings[i].Trim());
            }
            return arrayExemplo;
        }

        //Método para validar os números fornecidos pelo usuário
        private static bool ValidarEntradasNumericas(string[] entradas)
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

        //Método para imprimir o array, bem como a posição em que se encontra.
        private static void ImprimirArray()
        {
            int tamanho = TamanhoArray();
            int[] arrayExemplo = ConstruirArray(tamanho);
            Console.WriteLine("Imprimindo um array:\n");
            foreach (int i in arrayExemplo) { Console.WriteLine($"Item {Array.IndexOf(arrayExemplo, i) + 1}: {i}"); }
        }
    }
}
