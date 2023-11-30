using Vetores.Exercicios;

namespace Vetores
{
    // Classe Program, que serve como ponto de entrada principal para o programa
    public class Program
    {
        // Método principal que é chamado com uma escolha como parâmetro
        public static void MetodoPrincipal(int escolha)
        {
            // Verifica se a escolha é igual a 7
            if (escolha == 7)
            {
                // Se for, chama o método Main da classe Exercicio7
                Exercicio7.Main();
            }
        }
    }
}
