namespace LogicaMat.Exercicios
{
    internal class Exercicio5
    {
        internal static void Executar5()
        {
            // Chama o método para calcular a soma dos números de 1 a 100
            int soma = SomarNumerosDeUmACem();

            // Exibe o resultado
            Console.WriteLine($"A soma dos números de 1 a 100 é: {soma}");
        }

        // Método para calcular a soma dos números de 1 a 100
        private static int SomarNumerosDeUmACem()
        {
            // Fórmula da soma dos termos de uma progressão aritmética
            int soma = (100 + 1) * 100 / 2;

            // Retorna a soma calculada
            return soma;
        }
    }
}
