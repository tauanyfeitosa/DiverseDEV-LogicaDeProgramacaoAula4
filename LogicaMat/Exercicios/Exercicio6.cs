namespace LogicaMat.Exercicios
{
    internal class Exercicio6
    {
        internal static void Executar6()
        {
            // Variáveis para armazenar os resultados
            int quantidadeNumeros, soma, numerosPares;

            // Chama o método para ler números do usuário e calcular estatísticas
            LerNumeros(out quantidadeNumeros, out soma, out numerosPares);

            // Exibe os resultados
            Console.WriteLine($"Quantidade de números lidos: {quantidadeNumeros}");
            Console.WriteLine($"Soma total: {soma}");
            Console.WriteLine($"Quantidade de números pares: {numerosPares}");
        }

        // Método para ler números do usuário e calcular estatísticas
        private static void LerNumeros(out int quantidadeNumeros, out int soma, out int numerosPares)
        {
            // Inicializa as variáveis
            quantidadeNumeros = 0;
            soma = 0;
            numerosPares = 0;

            // Solicita ao usuário que digite números até que 0 seja inserido
            Console.WriteLine("Digite números (digite 0 para encerrar):");

            // Loop infinito para ler números
            while (true)
            {
                // Obtém um número inteiro do usuário
                int numero = ObterNumeroInteiro();

                // Encerra o loop quando o usuário digitar 0
                if (numero == 0)
                {
                    break;
                }

                // Atualiza as estatísticas
                quantidadeNumeros++;
                soma += numero;

                // Verifica se o número é par
                if (numero % 2 == 0)
                {
                    numerosPares++;
                }
            }
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
