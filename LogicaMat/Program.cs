using LogicaMat.Exercicios;

namespace LogicaMat
{
    public class Program
    {
        // Método principal que direciona para diferentes exercícios com base na escolha do usuário
        public static void MetodoPrincipal(int escolha)
        {
            // Verifica se a escolha do usuário é igual a 4
            if (escolha == 4)
            {
                // Se a escolha for 4, chama o método Main do Exercicio4
                Exercicio4.Main();
            }
            // Verifica se a escolha do usuário é igual a 5
            else if (escolha == 5)
            {
                // Se a escolha for 5, chama o método Executar5 do Exercicio5
                Exercicio5.Executar5();
            }
            // Caso a escolha não seja nem 4 nem 5
            else
            {
                // Chama o método Executar6 do Exercicio6
                Exercicio6.Executar6();
            }
        }
    }
}
