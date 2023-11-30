using ExercicioAvancado.Exercicios;

namespace ExercicioAvancado
{
    public class Program
    {
        // Método principal que direciona para diferentes exercícios com base na escolha do usuário
        public static void MetodoPrincipal(int escolha)
        {
            // Verifica se a escolha do usuário é igual a 8
            if (escolha == 8)
            {
                // Se a escolha for 8, chama o método Main do Exercicio8
                Exercicio8.Main();
            }
        }
    }
}
