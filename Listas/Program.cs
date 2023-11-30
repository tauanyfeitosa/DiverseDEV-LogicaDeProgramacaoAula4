using Listas.Exercicios;

namespace Listas
{
    public class Program
    {
        // Método principal que direciona para diferentes exercícios com base na escolha do usuário
        public static void MetodoPrincipal(int escolha)
        {
            // Verifica se a escolha do usuário é igual a 9
            if (escolha == 9)
            {
                // Se a escolha for 9, chama o método Main do Exercicio9
                Exercicio9.Main();
            }
        }
    }
}
