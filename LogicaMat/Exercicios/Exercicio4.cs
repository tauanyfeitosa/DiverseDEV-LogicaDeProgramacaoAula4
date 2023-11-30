namespace LogicaMat.Exercicios
{
    internal class Exercicio4
    {
        internal static void Main()
        {
            // Variáveis para armazenar os resultados
            int soma, menor;
            double media;

            // Chama o método para obter e exibir estatísticas, passando as variáveis por referência
            ObterEExibirEstatisticas(out soma, out media, out menor);

            // Exibe os resultados
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Média: {media}");
            Console.WriteLine($"Menor número: {menor}");
        }

        // Método para obter e exibir estatísticas dos números fornecidos pelo usuário
        private static void ObterEExibirEstatisticas(out int soma, out double media, out int menor)
        {
            Console.WriteLine("Digite 10 números inteiros:");

            // Inicializa as variáveis
            soma = 0;
            menor = int.MaxValue;
            media = 0;

            // Loop para obter 10 números inteiros do usuário
            for (int i = 0; i < 10; i++)
            {
                // Obtém um número inteiro do usuário
                int numero = ObterNumeroInteiro();
                // Atualiza a soma
                soma += numero;

                // Verifica se o número é menor que o menor atual
                if (numero < menor)
                {
                    menor = numero;
                }
            }

            // Calcula a média
            media = (double)soma / 10;
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
